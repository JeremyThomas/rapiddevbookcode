/*
* Last edit at 23Feb2007 by George Birbilis (birbilis@kagi.com)
* http://www.codeproject.com/KB/menus/MRUHandler.aspx
*
* 23Feb2007:
* - Birb: changed to work with MenuStrip (.NET2.0) instead of MenuBar (.NET1.x)
* - Birb: renamed all MenuItem to ToolStripMenuItem
* - Birb: see various bug fixes below by searching for "Birb:"
* - Birb: added "AutoSeparators" property
*/

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace AW.Winforms.Helpers.MostRecentlyUsedHandler
{
  /// Enumerated type for the MRUStyle property
  /// 
  /// 
  /// Popup
  /// The Most Recently Used list is shown as a pop up menu.
  /// 
  /// 
  /// Inline
  /// The Most Recenly Used list is included in the menu where the desginated item would go.
  public enum MRUStyle
  {
    Popup,
    Inline
  };

  /// Enumerated type for the defining the persistent storage location of the Most Recently Used history
  /// 
  /// 
  /// File
  /// The Most Recently Used list persisted to the local file system.
  /// 
  /// 
  /// Registry
  /// The Most Recenly Used list is stored in the win32 registry.
  /// 
  /// 
  /// IsolatedStorage
  /// The Most Recenly Used list persisted in the .Net Isolated Storage.
  public enum StorageStyle
  {
    File,
    Registry,
    IsolatedStorage
  };

  /// The delegate definition for the Most Recently Used menu click event
  public delegate void MRUItemClickedHandler(object sender, MRUItemClickedEventArgs e);

  /// Summary description for MRUHandler.
  [ToolboxBitmap(typeof (MRUHandler), "MRUHandler.bmp")]
  public class MRUHandler : Component, ISupportInitialize
  {
    #region private static definitions

    /// Defines the Most Recently Used file definition
    private const string MRU_EXTENSION = ".mru";

    /// Defines the registry key base name that is used to generate the key for each mru entry
    private const string REGISTRY_VALUE_NAME_BASE = "mru_entry_";

    #endregion

    public event MRUItemClickedHandler MRUItemClicked;

    #region Constructors

    public MRUHandler(IContainer container)
    {
      container.Add(this);
    }

    public MRUHandler()
    {
    }

    #endregion

    #region property field definitions

    private ToolStripMenuItem _mruItem;
    private MRUStyle _style;
    private StorageStyle _storageStyle = StorageStyle.IsolatedStorage;
    private int _maxFiles = 10;
    private int _displayLength = 40;
    private string _fileName = "mru";
    private bool _showShortItem;
    private bool _autoSeparators; //Birb (default value is "False" to maintain backwards compatibility)

    #endregion

    #region internal field definitions

    private readonly Hashtable _itemMap = new Hashtable();
    private bool _mruIsDirty;
    private ArrayList _mru;
    private bool _isInitializing;

    [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
    private static extern bool PathCompactPathEx(StringBuilder pszOut, string pszPath, int cchMax, int reserved);

    #endregion

    /// Is the internal menu click handler for all of the Most Recently Used menu items. Based on the menuitem
    /// the file name is retrieved from the Hashtable. The display text of the item will not be a usable file name.
    /// For instance it has a number in front and the text could have been compressed by the 'ShowShortItem' property
    /// 
    /// Object that raised the event
    /// Event information
    private void onMenuItemClick(Object sender, EventArgs e)
    {
      var item = (ToolStripMenuItem) sender;
      if (MRUItemClicked != null)
      {
        var fileName = (string) _itemMap[item];
        MRUItemClicked(this, new MRUItemClickedEventArgs(fileName));
      }
    }

    /// Add a file path name to the Most Recently Used history
    /// 
    /// path to be added
    public void AddRecentlyUsedFile(string fileName)
    {
      MRUList().Remove(fileName);
      MRUList().Insert(0, fileName);
      for (var i = _mru.Count; i > _maxFiles;)
        _mru.RemoveAt(--i);
      _mruIsDirty = true;
      RebuildMenu();
    }

    #region properties

    /// Property to determine the menuitem that becomes the place holder for the
    /// Most Recently Used Menu items.
    [Description("Specifies the menu item that is used as the MRU list parent.")]
    public ToolStripMenuItem MruItem
    {
      get { return _mruItem; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'MruItem' can be only set in Design Mode");
        _mruItem = value;
      }
    }

    /// Property that specifies what name is used in the storage of the MRU history
    [Description("Specifies the name to be used to generate the file name for persistence.")]
    public string StorageName
    {
      get { return _fileName; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'StorageName' can be only set in Design Mode");
        _fileName = value;
      }
    }

    /// Property that determins the style of the MRU list at runtime
    [Description("Specifies the style of the MRU list."),
     DefaultValue(MRUStyle.Popup)]
    public MRUStyle MRUStyle
    {
      get { return _style; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'MRUStyle' can be only set in Design Mode");
        _style = value;
      }
    }

    /// Property to determine if the MRU menu item will show the truncated text.
    [Description("Specifies whether the file name in the MRU entry should be truncated."),
     DefaultValue(false)]
    public bool ShowShortItem
    {
      get { return _showShortItem; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'ShowShortItem' can be only set in Design Mode");
        _showShortItem = value;
      }
    }

    /// Property to determine if separators will be automatically placed arround inline MRU entries when necessery.
    [Description("Specifies whether separators will be automatically placed arround inline MRU entries when necessery."),
     DefaultValue(false)] //default value is "False" to maintain backwards compatibility
    public bool AutoSeparators //Birb: added
    {
      get { return _autoSeparators; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'AutoSeparators' can be only set in Design Mode");
        _autoSeparators = value;
      }
    }

    /// Property to determine the type of persistent storage that should be used to store the MRU history.
    [Description("Specifies the type of persistent storage to use to store the MRU history."),
     DefaultValue(StorageStyle.IsolatedStorage)]
    public StorageStyle StorageStyle
    {
      get { return _storageStyle; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'StorageStyle' can be only set in Design Mode");
        _storageStyle = value;
      }
    }

    /// Property to determine the length of the MRU history.
    [Description("Specifies the length of the MRU history file."),
     DefaultValue(10)]
    public int MaxFiles
    {
      get { return _maxFiles; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'MaxFiles' can be only set in Design Mode");
        _maxFiles = value;
        if (_mru != null) //Birb: added this check to bypass null pointer exception case, described at http://www.codeproject.com/cs/menu/MRUHandler.asp?forumid=124432&select=1114259&df=100#xx1114259xx
          _mru.Capacity = _maxFiles;
      }
    }

    /// Property to determine the length of text to be shown if the ShowShortItem property is set to true.
    [Description("Specifies the length of the MRU menu text when the ShowShortItem property is true."),
     DefaultValue(40)]
    public int DisplayLength
    {
      get { return _displayLength; }
      set
      {
        if (!DesignMode && !_isInitializing)
          throw new Exception("The 'DisplayLength' can be only set in Design Mode");
        _displayLength = value;
      }
    }

    #endregion

    #region Component overrides

    /// Clean up any resources being used.
    protected override void Dispose(bool disposing)
    {
      if (_mruIsDirty)
      {
        switch (_storageStyle)
        {
          case StorageStyle.File:
            saveToFile();
            break;
          case StorageStyle.Registry:
            saveToRegistry();
            break;
          default:
            saveToStorage();
            break;
        }
        _mruIsDirty = false;
      }
      base.Dispose(disposing);
    }

    #endregion

    #region Access MRU in a file in Isolated Storage

    private ArrayList loadFromStorage()
    {
      var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
      // isoStore.DeleteFile(MRUFile());
      if (isoStore.GetFileNames(MRUFile()).Length == 0)
        // File not exists. Create an empty file
        return new ArrayList();

      // Read the stream from Isolated Storage.
      Stream stream = new IsolatedStorageFileStream(MRUFile(), FileMode.OpenOrCreate, isoStore);
      try
      {
        // DeSerialize the Hashtable from stream.
        IFormatter formatter = new BinaryFormatter();
        var appData = (ArrayList) formatter.Deserialize(stream);
        return appData;
      }
      finally
      {
        // We are done with it.
        stream.Close();
      }
    }

    private void saveToStorage()
    {
      // Open the stream from the IsolatedStorage.
      var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
      Stream stream = new IsolatedStorageFileStream(MRUFile(), FileMode.Create, isoStore);

      try
      {
        // Serialize the Hashtable into the IsolatedStorage.
        IFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, MRUList());
      }
      finally
      {
        stream.Close();
      }
    }

    #endregion

    #region Access MRU in a file on the file system

    private ArrayList loadFromFile()
    {
      _mruIsDirty = false;
      var mruLF = new MRUListFile();
      var fi = new FileInfo(Application.ExecutablePath);

      mruLF.ReadXml(fi.DirectoryName + '\\' + MRUFile(), XmlReadMode.IgnoreSchema);
      var mru = new ArrayList(mruLF.MRUList.Rows.Count);

      foreach (MRUListFile.MRUListRow row in mruLF.MRUList.Rows)
        mru.Add(row.mruentry);

      return mru;
    }

    private void saveToFile()
    {
      var mruLF = new MRUListFile();
      foreach (String str in MRUList())
        mruLF.MRUList.AddMRUListRow(str);
      var fi = new FileInfo(Application.ExecutablePath);

      /*---------------*/
      //Birb: changed to address the issue mentioned at http://www.codeproject.com/cs/menu/MRUHandler.asp?forumid=124432&select=1371902&df=100#xx1371902xx
      var filename = (fi.DirectoryName + '\\' + MRUFile());
      if (!File.Exists(filename)) File.Create(filename);
      mruLF.WriteXml(filename, XmlWriteMode.IgnoreSchema);
      /*---------------*/
    }

    #endregion

    #region Access MRU stored in the registry

    private ArrayList loadFromRegistry()
    {
      var key = Application.UserAppDataRegistry;
      if (key == null) return new ArrayList();
      var mruKey = key.OpenSubKey(_fileName, true);
      if (mruKey == null) return new ArrayList();
      // does it exist, if so load the values
      var mruCount = mruKey.GetValue("mru_count");
      var mruSize = (int) mruCount;
      var mru = new ArrayList(mruSize);
      for (var i = 0; i < mruSize; i++)
      {
        var sb = new StringBuilder(REGISTRY_VALUE_NAME_BASE.Length + 10);
        sb.Append(REGISTRY_VALUE_NAME_BASE).Append(i);
        mru.Add(mruKey.GetValue(sb.ToString()));
      }

      return mru;
    }

    private void saveToRegistry()
    {
      /*-------------*/
      //Birb: changed as advised at http://www.codeproject.com/cs/menu/MRUHandler.asp?forumid=124432&select=975936&df=100#xx975936xx
      var key = Application.UserAppDataRegistry;

      // no child keys anyway but also say don't throw
      if (key == null) return;
      key.DeleteSubKey(_fileName, false); // so we can replace all the duplicates

      var mruKey = key.CreateSubKey(_fileName);
      /*-------------*/

      var counter = 0;
      if (mruKey == null) return;
      mruKey.SetValue("mru_count", MRUList().Count);
      foreach (String str in MRUList())
      {
        var sb = new StringBuilder(REGISTRY_VALUE_NAME_BASE.Length + 10);
        sb.Append(REGISTRY_VALUE_NAME_BASE).Append(counter++);
        mruKey.SetValue(sb.ToString(), str);
      }
    }

    #endregion

    #region menu item builder functions

    /// Rebuilds the Most Rcently Used menu base on the value of the MRUStyle property
    private void RebuildMenu()
    {
      if (_style == MRUStyle.Popup)
        RebuildPopupMenu(); //Birb: moved code to "RebuildPopupMenu"
      else
        RebuildInlineMenu();
    }

    /// Rebuild the popup version of the most recently used list
    private void RebuildPopupMenu() //Birb: added for better code readability (since original code already had a separate "RebuildInlineMenu")
    {
      _mruItem.DropDownItems.Clear(); //Birb: renamed MenuItems to DropDownItems
      _itemMap.Clear();
      _mruItem.Enabled = MRUList().Count > 0;
      var counter = 1;
      foreach (string str in MRUList())
      {
        var item = buildMenuItem(counter++, str);
        _itemMap.Add(item, str);
        _mruItem.DropDownItems.Add(item); //Birb: renamed MenuItems to DropDownItems
      }
    }

    /// Rebuild the inline version of the most recently used list
    private void RebuildInlineMenu()
    {
      foreach (ToolStripMenuItem item in _itemMap.Keys)
        // dispose all the existing menu items
        item.Dispose();

      _itemMap.Clear(); // Now that the menuitems are disposed, clear the table

      if (MRUList().Count > 0)
        // if no mru list then leave the place holder visible
        _mruItem.Visible = false; // force the place holder item to inert
      _mruItem.Enabled = false;

      var offset = 1;
      var parentMenu = (ToolStripMenuItem) _mruItem.OwnerItem; // get our parent //Birb: renamed Parent to OwnerItem
      var parentItems = parentMenu.DropDownItems; //Birb: used instead of parentMenu.MenuItems
      var MRUMenuIndex = /*_mruItem.Index*/ parentItems.IndexOf(_mruItem); // where are we in the chain //Birb: changed the code to find the _mruItem index inside its parent since there's no Index property at ToolStripItem

      if (_autoSeparators && (MRUList().Count > 0))
      {
        //Birb

        //Birb: "prepend" separator to mru item if not first item and not existing already
        if ((MRUMenuIndex != 0) && !(parentItems[MRUMenuIndex - 1] is ToolStripSeparator))
        {
          parentMenu.DropDownItems.Insert(MRUMenuIndex, new ToolStripSeparator());
          MRUMenuIndex += 1; //update the mru item index since we prepended a separator
        }

        //Birb: "append" separator to mru item if not last item and not existing already
        if ((MRUMenuIndex != parentItems.Count - 1) && !(parentItems[MRUMenuIndex + 1] is ToolStripSeparator))
          parentMenu.DropDownItems.Insert(MRUMenuIndex + 1, new ToolStripSeparator());
        //don't update the mru item index, we appended something (didn't prepend anything)
      }

      foreach (string str in MRUList())
      {
        var item = buildMenuItem(offset, str);
        _itemMap.Add(item, str);
        parentItems.Insert(MRUMenuIndex + offset, item); //Birb: renamed parentMenu.MenuItems to parentItems, renamed Add to Insert
        offset++;
      }
    }

    /// Builds a menu item for the path entry
    /// 
    /// Position in list
    /// path
    private ToolStripMenuItem buildMenuItem(int position, string text)
    {
      var sb = new StringBuilder(text.Length + 10);
      if (position < 10)
        // only put ampersands on the first 9, otherwise
        sb.Append('&'); // we can't tell the difference between 1 & 10
      sb.Append(position).Append(' ');
      sb.Append(!_showShortItem ? text : GetShortDisplayName(text, _displayLength));

      var item = new ToolStripMenuItem(sb.ToString());

      if (_style == MRUStyle.Inline)
      {
        item.MergeIndex = _mruItem.MergeIndex; //Birb: renamed MergeOrder to MergeIndex
        item.MergeAction = _mruItem.MergeAction; //Birb: renamed MergeType to MergeAction
      }

      item.Click += onMenuItemClick;

      return item;
    }

    /// Truncate a path to fit within a certain number of characters
    /// by replacing path components with ellipses.
    /// 
    /// This solution is provided by CodeProject and GotDotNet C# expert
    /// Richard Deeming.
    /// 
    /// 
    /// Long file name
    /// Maximum length
    /// Truncated file name
    private string GetShortDisplayName(string longName, int maxLen)
    {
      var pszOut = new StringBuilder(maxLen + maxLen + 2); // for safety
      if (PathCompactPathEx(pszOut, longName, maxLen, 0))
        return pszOut.ToString();
      return longName;
    }

    #endregion

    #region internal helper functions

    /// Generates a standard file name to be used to persist the mru history.
    /// The formation is product name_file name property.mru
    /// 
    /// A string representing the file name to be used to store the mru history/returns>
    private string MRUFile()
    {
      var sb = new StringBuilder(256);
      sb.Append(Application.ProductName).Append('_').Append(_fileName).Append(MRU_EXTENSION);
      return sb.ToString();
    }

    /// Loads the mru history from the defined storage location.
    /// 
    /// An array containing the MRU history
    private ArrayList MRUList()
    {
      if (_mru == null)
      {
        switch (_storageStyle)
        {
          case StorageStyle.File:
            _mru = loadFromFile();
            break;
          case StorageStyle.Registry:
            _mru = loadFromRegistry();
            break;
          default:
            _mru = loadFromStorage();
            break;
        }
        _mruIsDirty = false;
        for (var i = _mru.Count; i > _maxFiles;)
          _mru.RemoveAt(--i);
      }

      return _mru;
    }

    #endregion

    #region ISupportInitialize Implementation

    /// Implementation of the BeginInit Method. Set a flag so that we are initializing the
    /// component by the framework. This will bypass all the run time error check on setting
    /// the parameters.
    public void BeginInit()
    {
      _isInitializing = true;
    }

    /// Implementation of the EndInit Method. When we this method is called, the framework
    /// has completed initializing the component with the values that were set in the designer.
    /// We now set the flag so that run time parameter setting is basically disabled.
    public void EndInit()
    {
      _isInitializing = false;
      if (!DesignMode)
      {
        if (_mruItem == null)
          throw new Exception("The property 'MruItem' item cannot be set to null");
        RebuildMenu();
      }
    }

    #endregion
  }

  /// The event arguments for the generated Most Recently Used menu click event
  public class MRUItemClickedEventArgs : EventArgs
  {
    private readonly string _file;

    public MRUItemClickedEventArgs(string file)
    {
      _file = file;
    }

    public string File
    {
      get { return _file; }
    }
  }
}