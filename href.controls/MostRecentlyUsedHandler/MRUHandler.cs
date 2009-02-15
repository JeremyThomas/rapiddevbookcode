using System;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Microsoft.Win32;

namespace AW.Winforms.Helpers.MostRecentlyUsedHandler
{
  /// <summary>
  /// http://www.codeproject.com/KB/menus/MRUHandler.aspx
  /// </summary>
  [ToolboxBitmap(typeof(MRUHandler), "MRUHandler.bmp")]
  public class MRUHandler : Component, ISupportInitialize {

    #region private static definitions
    /// <summary>
    /// Defines the Most Recently Used file definition
    /// </summary>
    private static readonly string MRU_EXTENSION = ".mru";
    /// <summary>
    /// Defines the registry key base name that is used to generate the key for each mru entry
    /// </summary>
    private static readonly string REGISTRY_VALUE_NAME_BASE = "mru_entry_";
    #endregion
				
    public event MRUItemClickedHandler MRUItemClicked;
		
    #region Constructors
    public MRUHandler(System.ComponentModel.IContainer container) {
      container.Add(this);
    }

    public MRUHandler() {}
    #endregion
		
    #region property field definitions
    private MenuItem		_mruItem;
    private MRUStyle		_style;
    private StorageStyle	_storageStyle = StorageStyle.IsolatedStorage;
    private int				_maxFiles = 10;
    private int				_displayLength = 40;
    private string			_fileName = "mru";
    private bool			_showShortItem;
    #endregion

    #region internal field definitions
    private Hashtable		_itemMap = new Hashtable();
    private bool			_mruIsDirty;
    private ArrayList		_mru;
    private bool			_isInitializing = false;

    [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]   
    private static extern bool PathCompactPathEx(StringBuilder pszOut, string pszPath, int cchMax, int reserved);
    #endregion

    /// <summary>
    /// Is the internal menu click handler for all of the Most Recently Used menu items.  Based on the menuitem
    /// the file name is retrieved from the Hashtable.  The display text of the item will not be a usable file name.
    /// For instance it has a number in front and the text could have been compressed by the 'ShowShortItem' property
    /// </summary>
    /// <param name="sender">Object that raised the event</param>
    /// <param name="e">Event information</param>
    protected void onMenuItemClick(Object sender, EventArgs e) {
      MenuItem item = (MenuItem)sender;
      if (MRUItemClicked != null) {
        string fileName = (string)_itemMap[item];
        MRUItemClicked(this, new MRUItemClickedEventArgs(fileName));
      }
    }

    /// <summary>
    /// Add a file path name to the Most Recently Used history
    /// </summary>
    /// <param name="fileName">path to be added</param>
    public void AddRecentlyUsedFile(string fileName) {
      MRUList().Remove(fileName);
      MRUList().Insert(0, fileName);
      for (int i = _mru.Count; i > _maxFiles; ) {
        _mru.RemoveAt(--i);
      }
      _mruIsDirty = true;
      RebuildMenu();
    }
		
    #region properties
		
    /// <summary>
    /// Property to determine the menuitem that becomes the place holder for the 
    /// Most Recently Used Menu items.
    /// </summary>
    [Description("Specifies the menu item that is used as the MRU list parent.")]
    public MenuItem MruItem {
      get{ return _mruItem;  }
      set{ 
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'MruItem' can be only set in Design Mode");
        }
        _mruItem = value; 
      }
    }

    /// <summary>
    /// Property that specifies what name is used in the storage of the MRU history
    /// </summary>
    [Description("Specifies the name to be used to generate the file name for persistence.")]
    public string StorageName {
      get{ return _fileName;  }
      set {
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'StorageName' can be only set in Design Mode");
        }
        _fileName = value;	
      }
    }

    /// <summary>
    /// Property that determins the style of the MRU list at runtime
    /// </summary>
    [Description("Specifies the style of the MRU list."),
     DefaultValue(MRUStyle.Popup)]
    public MRUStyle MRUStyle {
      get{ return _style;  }
      set{
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'MRUStyle' can be only set in Design Mode");
        }
        _style = value;
      }
    }

    /// <summary>
    /// Property to determine if the MRU menu item will show the truncated text.
    /// </summary>
    [Description("Specifies whether the file name in the MRU entry should be truncated."),
     DefaultValue(false)]
    public bool ShowShortItem {
      get{ return _showShortItem;  }
      set{
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'ShowShortItem' can be only set in Design Mode");
        }
        _showShortItem = value;  
      }
    }

    /// <summary>
    /// Property to determine the type of persistent storage that should be used to store the MRU history.
    /// </summary>
    [Description("Specifies the type of persistent storage to use to store the MRU history."),
     DefaultValue(StorageStyle.IsolatedStorage)]
    public StorageStyle StorageStyle {
      get{ return _storageStyle;  }
      set{
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'StorageStyle' can be only set in Design Mode");
        }
        _storageStyle = value;
      }
    }
		
    /// <summary>
    /// Property to determine the length of the MRU history.
    /// </summary>
    [Description("Specifies the length of the MRU history file."),
     DefaultValue(10)]
    public int MaxFiles {
      get{ return _maxFiles;  }
      set{ 
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'MaxFiles' can be only set in Design Mode");
        }
        _maxFiles = value;
        _mru.Capacity = _maxFiles;
      }
    }
		
    /// <summary>
    /// Property to determine the length of text to be shown if the ShowShortItem property is set to true.
    /// </summary>
    [Description("Specifies the length of the MRU menu text when the ShowShortItem property is true."),
     DefaultValue(40)]
    public int DisplayLength {
      get{ return _displayLength;  }
      set{ 
        if (!DesignMode && !_isInitializing) {
          throw new Exception("The 'DisplayLength' can be only set in Design Mode");
        }
        _displayLength = value; 
      }
    }
    #endregion

    #region Component overrides
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing ) {
      if (_mruIsDirty) {
        switch (_storageStyle) {
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
      base.Dispose( disposing );
    }

    #endregion

    #region Access MRU in a file in Isolated Storage
    private ArrayList loadFromStorage() {
      IsolatedStorageFile isoStore =  IsolatedStorageFile.GetStore( IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null );
//							isoStore.DeleteFile(MRUFile());
      if ( isoStore.GetFileNames( MRUFile() ).Length == 0 ) {
        // File not exists. Create an empty file
        return new ArrayList();
      }

      // Read the stream from Isolated Storage.
      Stream stream = new IsolatedStorageFileStream( MRUFile(), FileMode.OpenOrCreate, isoStore );
      if ( stream != null ) {
        try {
          // DeSerialize the Hashtable from stream.
          IFormatter formatter = new BinaryFormatter();
          ArrayList appData = ( ArrayList ) formatter.Deserialize(stream);
          return appData;
        }
        finally {
          // We are done with it.
          stream.Close();
        }
      } else {
        return new ArrayList();
      }
    }		
    private void saveToStorage() {
      // Open the stream from the IsolatedStorage.
      IsolatedStorageFile isoStore =  IsolatedStorageFile.GetStore( IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null );
      Stream stream = new IsolatedStorageFileStream( MRUFile(), FileMode.Create, isoStore );

      if ( stream != null ) {
        try {
          // Serialize the Hashtable into the IsolatedStorage.
          IFormatter formatter = new BinaryFormatter();
          formatter.Serialize( stream, MRUList() );
        }
        finally {
          stream.Close();
        }
      }
    }		
    #endregion
		
    #region Access MRU in a file on the file system
    private ArrayList loadFromFile() {
      _mruIsDirty = false;
      MRUListFile mruLF = new MRUListFile();
      FileInfo fi = new FileInfo(Application.ExecutablePath);
			
      mruLF.ReadXml(fi.DirectoryName+'\\'+MRUFile(), System.Data.XmlReadMode.IgnoreSchema);
      ArrayList mru = new ArrayList(mruLF.MRUList.Rows.Count);
			
      foreach (MRUListFile.MRUListRow row in mruLF.MRUList.Rows) {
        mru.Add(row.mruentry);
      }

      return mru;
    }
				
    private void saveToFile() {
      MRUListFile mruLF = new MRUListFile();
      foreach (String str in MRUList()) {
        mruLF.MRUList.AddMRUListRow(str);
      }
      FileInfo fi = new FileInfo(Application.ExecutablePath);
      mruLF.WriteXml(fi.DirectoryName+'\\'+MRUFile(), XmlWriteMode.IgnoreSchema);
    }		
    #endregion

    #region Access MRU stored in the registry
    private ArrayList loadFromRegistry() {
      RegistryKey key = Application.UserAppDataRegistry;
      RegistryKey mruKey = key.OpenSubKey(_fileName, true);
      if (mruKey != null) {							//	does it exist, if so load the values
        object mruCount = mruKey.GetValue("mru_count");
        int mruSize = (int)mruCount;
        ArrayList mru = new ArrayList(mruSize);
        for (int i=0; i < mruSize; i++) {
          StringBuilder sb = new StringBuilder(REGISTRY_VALUE_NAME_BASE.Length+10);
          sb.Append(REGISTRY_VALUE_NAME_BASE).Append(i);
          mru.Add(mruKey.GetValue(sb.ToString()));
        }
			
        return mru;
      }
      else {
        return new ArrayList();
      }
    }		

    private void saveToRegistry() {
      RegistryKey key = Application.UserAppDataRegistry;
      RegistryKey mruKey = key.OpenSubKey(_fileName, true);
      if (mruKey != null) {						//	Delete the existing key
        mruKey.DeleteSubKeyTree(_fileName);		//	so we can replace all the duplicates
      }
      mruKey = key.CreateSubKey(_fileName);
      int counter = 0;
      mruKey.SetValue("mru_count", MRUList().Count);
      foreach (String str in MRUList()) {
        StringBuilder sb = new StringBuilder(REGISTRY_VALUE_NAME_BASE.Length+10);
        sb.Append(REGISTRY_VALUE_NAME_BASE).Append(counter++);
        mruKey.SetValue(sb.ToString(), str);
      }
    }
    #endregion	

    #region menu item builder functions
    /// <summary>
    /// Rebuilds the Most Rcently Used menu base on the value of the MRUStyle property
    /// </summary>
    private void RebuildMenu() {
      if (_style == MRUStyle.Popup) {
        _mruItem.MenuItems.Clear();
        _itemMap.Clear();
        _mruItem.Enabled = MRUList().Count > 0;
        int counter = 1;
        foreach (string str in MRUList()) {
          MenuItem item = buildMenuItem(counter++, str);
          _itemMap.Add(item, str);
          _mruItem.MenuItems.Add(item);
        }
      }
      else {
        RebuildInlineMenu();
      }
    }

    /// <summary>
    /// Rebuild the inline version of the most recently used list
    /// </summary>
    private void RebuildInlineMenu() {
      foreach (MenuItem item in _itemMap.Keys) {		//	dispose all the existing menu items
        item.Dispose();
      }

      _itemMap.Clear();								//	Now that the menuitems are disposed, clear the tablae

      if (MRUList().Count > 0) {						//	if no mru list then leave the place holder visible
        _mruItem.Visible = false;					//	force the place holder item to inert
      }
      _mruItem.Enabled = false;

      int offset = 1;
      MenuItem parentMenu = (MenuItem)_mruItem.Parent;//	get our parent
      int MRUMenuIndex = _mruItem.Index;				//	where are we in the chain

      foreach (string str in MRUList()) {
        MenuItem item = buildMenuItem(offset, str);
        _itemMap.Add(item, str);
        parentMenu.MenuItems.Add(MRUMenuIndex+offset, item);
        offset++;
      }
    }
		
    /// <summary>
    /// Builds a menu item for the path entry
    /// </summary>
    /// <param name="position">Position in list</param>
    /// <param name="text">path</param>
    /// <returns></returns>
    private MenuItem buildMenuItem(int position, string text) {
      StringBuilder sb = new StringBuilder(text.Length + 10);
      if (position < 10) {							//	only put ampersands on the first 9, otherwise
        sb.Append('&');								//	we can't tell the difference between 1 & 10
      }
      sb.Append(position).Append(' ');
      sb.Append(!_showShortItem ? text : GetShortDisplayName(text, _displayLength));

      MenuItem item = new MenuItem(sb.ToString());

      if (_style == MRUStyle.Inline) {
        item.MergeOrder = _mruItem.MergeOrder;
        item.MergeType = _mruItem.MergeType;
      }

      item.Click += new System.EventHandler(onMenuItemClick);

      return item;
    }
		
    /// <summary>
    /// Truncate a path to fit within a certain number of characters
    /// by replacing path components with ellipses.
    ///
    /// This solution is provided by CodeProject and GotDotNet C# expert
    /// Richard Deeming.
    ///
    /// </summary>
    /// <param name="longName">Long file name</param>
    /// <param name="maxLen">Maximum length</param>
    /// <returns>Truncated file name</returns>
    private string GetShortDisplayName(string longName, int maxLen) {
      StringBuilder pszOut = new StringBuilder(maxLen + maxLen + 2);  // for safety
      if ( PathCompactPathEx(pszOut, longName, maxLen, 0) ) {
        return pszOut.ToString();
      }
      else {
        return longName;
      }
    }
		
    #endregion	

    #region internal helper functions
    /// <summary>
    /// Generates a standard file name to be used to persist the mru history.
    /// The formation is <i>product name</i>_<i>file name property</i>.mru
    /// </summary>
    /// <returns>A string representing the file name to be used to store the mru history/returns>
    private string MRUFile() {
      StringBuilder sb = new StringBuilder(256);
      sb.Append(Application.ProductName).Append('_').Append(_fileName).Append(MRU_EXTENSION);
      return sb.ToString();
    }
		
    /// <summary>
    /// Loads the mru history from the defined storage location.
    /// </summary>
    /// <returns>An array containing the MRU history</returns>
    private ArrayList MRUList() {
      if (_mru == null) {
        switch (_storageStyle) {
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
        for (int i = _mru.Count; i > _maxFiles; ) {
          _mru.RemoveAt(--i);
        }
      }

      return _mru;
    }
    #endregion

    #region ISupportInitialize Implementation
    /// <summary>
    /// Implementation of the BeginInit Method.  Set a flag so that we are initializing the
    /// component by the framework.  This will bypass all the run time error check on setting
    /// the parameters.
    /// </summary>
    public void BeginInit() {_isInitializing = true;}
		
    /// <summary>
    /// Implementation of the EndInit Method.  When we this method is called, the framework 
    /// has completed initializing the component with the values that were set in the designer.
    /// We now set the flag so that run time parameter setting is basically disabled.
    /// </summary>
    public void EndInit() {
      _isInitializing = false;
      if (!DesignMode) {
        if (_mruItem == null) {
          throw new Exception("The property 'MruItem' item cannot be set to null");
        }
        RebuildMenu();
      }
    }
    #endregion
  }

  /// <summary>
  /// Enumerated type for the MRUStyle property
  /// <list type="bullet">
  /// <item>
  /// <term>Popup</term>
  /// <description>The Most Recently Used list is shown as a pop up menu.</description>
  /// </item>
  /// <item>
  /// <term>Inline</term>
  /// <description>The Most Recenly Used list is included in the menu where the desginated item would go.</description>
  /// </item>
  /// </list>
  /// </summary>
  public enum MRUStyle { Popup, Inline };

  /// <summary>
  /// Enumerated type for the defining the persistent storage location of the Most Recently Used history
  /// <list type="bullet">
  /// <item>
  /// <term>File</term>
  /// <description>The Most Recently Used list persisted to the local file system.</description>
  /// </item>
  /// <item>
  /// <term>Registry</term>
  /// <description>The Most Recenly Used list is stored in the win32 registry.</description>
  /// </item>
  /// <item>
  /// <term>IsolatedStorage</term>
  /// <description>The Most Recenly Used list persisted in the .Net Isolated Storage.</description>
  /// </item>
  /// </list>
  /// </summary>
  public enum StorageStyle { File, Registry, IsolatedStorage };

  /// <summary>
  /// The event arguments for the generated Most Recently Used menu click event
  /// </summary>
  public class MRUItemClickedEventArgs : EventArgs
  {
    private string _file;
    public MRUItemClickedEventArgs(string file) { _file = file; }

    public string File { get { return _file; } }
  }

  /// <summary>
  /// The delegate definition for the Most Recently Used menu click event
  /// </summary>
  public delegate void MRUItemClickedHandler(object sender, MRUItemClickedEventArgs e);
}