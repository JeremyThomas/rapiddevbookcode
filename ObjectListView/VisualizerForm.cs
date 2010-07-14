using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JesseJohnston
{
  internal partial class VisualizerForm : Form
  {
    private ObjectListView view;
    private string listTypeName;
    private string listItemTypeName;
    private bool iEditableObject;
    private bool iNotifyPropertyChanged;
    private bool propertyChangeEvents;
    private bool listChanged;
    private bool iRaiseItemChangedEvents;
    private bool synced;

    public ObjectListView View
    {
      get { return view; }
      set
      {
        if (value == null)
          throw new ArgumentNullException("View");
        view = value;
      }
    }

    public VisualizerForm()
    {
      InitializeComponent();
    }

    protected override void OnCreateControl()
    {
      base.OnCreateControl();

      if (view == null)
        throw new ArgumentNullException("View");

      GetTypeNames();
      ShowListItemProperties();
      ShowListProperties();
      ShowView();
      ShowList();
    }

    private void ShowListProperties()
    {
      labelListType.Text = listTypeName;
      toolTip.SetToolTip(labelListType, view.List.GetType().FullName);

      if (ListSupportsListChanged(view.List))
      {
        listChanged = true;
        labelListSupportsListChanged.Text = "Yes";
        labelListSupportsListChanged.ForeColor = Color.Green;
      }
      if (view.List is IRaiseItemChangedEvents && ((IRaiseItemChangedEvents) view.List).RaisesItemChangedEvents)
      {
        iRaiseItemChangedEvents = true;
        labelListIRaiseItemChangedEvents.Text = "Yes";
        labelListIRaiseItemChangedEvents.ForeColor = Color.Green;
      }

      if (!view.List.IsFixedSize)
        labelFixedSize.Visible = false;

      if (!view.List.IsSynchronized)
        labelSynced.Visible = false;
      else
        synced = true;

      if (!view.List.IsReadOnly)
        labelReadOnly.Visible = false;

      foreach (ListSortDescription sort in view.SortDescriptions)
        listViewSort.Items.Add(new ListViewItem(new[] {sort.PropertyDescriptor.Name, sort.SortDirection.ToString()}));

      textBoxFilter.Text = view.FilterPredicate == null ? view.Filter : "(FilterPredicate is in effect)";
    }

    private void ShowListItemProperties()
    {
      if (view.ItemType != null)
      {
        labelListItemType.Text = listItemTypeName;
        toolTip.SetToolTip(labelListItemType, view.ItemType.FullName);

        if (typeof (INotifyPropertyChanged).IsAssignableFrom(view.ItemType))
        {
          iNotifyPropertyChanged = true;
          labelINotifyPropertyChanged.Text = "Yes";
          labelINotifyPropertyChanged.ForeColor = Color.Green;
        }

        var notifyingProps = GetPropertyChangedEvents(view.ItemType);
        if (notifyingProps.Count > 0)
        {
          propertyChangeEvents = true;
          labelPropertyChangedEvents.Text = "Yes";
          labelPropertyChangedEvents.ForeColor = Color.Green;
          toolTip.SetToolTip(labelPropertyChangedEvents, MakeTooltip(notifyingProps));

          if (!iNotifyPropertyChanged)
            labelINotifyPropertyChanged.ForeColor = Color.DarkOrange;
        }
        else if (!iNotifyPropertyChanged)
          labelPropertyChangedEvents.ForeColor = Color.Red;

        if (typeof (IEditableObject).IsAssignableFrom(view.ItemType))
        {
          iEditableObject = true;
          labelIEditableObject.Text = "Yes";
          labelIEditableObject.ForeColor = Color.Green;
        }
      }
    }

    private void ShowView()
    {
      var props = ((ITypedList) view).GetItemProperties(null).Cast<PropertyDescriptor>().ToList();
      props.Sort((desc1, desc2) => string.Compare(desc1.Name, desc2.Name, true));

      // When deciding whether to use a DataGridTableStyle that we have provided, or to use the default table style, DataGrid
      // tries to match the MappingName of our table style against the list name.  If it doesn't match, the default table style
      // is used.  The mapping name of our table style is "", the default.  This matches the list name returned by ObjectListView's
      // implementation of ITypedList.GetListName().

    	foreach (var column in props.Distinct().Select(prop => new DataGridTextBoxColumn {HeaderText = prop.Name, MappingName = prop.Name, NullText = "", ReadOnly = true})
    		.Where(column => !dataGridViewTableStyle.GridColumnStyles.Contains(column.HeaderText)))
    		dataGridViewTableStyle.GridColumnStyles.Add(column);

    	dataGridView.DataSource = view;
    }

    private void ShowList()
    {
      var props = TypeDescriptor.GetProperties(view.ItemType).Cast<PropertyDescriptor>().ToList();
      props.Sort((desc1, desc2) => string.Compare(desc1.Name, desc2.Name, true));

      // When deciding whether to use a DataGridTableStyle that we have provided, or to use the default table style, DataGrid
      // tries to match the MappingName of our table style against the list name.  If it doesn't match, the default table style
      // is used.  The logic below assigns the mapping name to mimic the way that the DataGrid list manager retrieves the name of the list.
      if (view.List is ITypedList)
        dataGridListTableStyle.MappingName = ((ITypedList) view.List).GetListName(null);
      else
        dataGridListTableStyle.MappingName = view.List.GetType().Name;

    	foreach (var column in props.Distinct().Select(prop => new DataGridTextBoxColumn {HeaderText = prop.Name, MappingName = prop.Name, NullText = "", ReadOnly = true})
    		.Where(column => !dataGridViewTableStyle.GridColumnStyles.Contains(column.HeaderText)))
    		dataGridListTableStyle.GridColumnStyles.Add(column);

    	dataGridList.DataSource = view.List;
    }

    private void GetTypeNames()
    {
      listItemTypeName = view.ItemType.Name;

      var listType = view.List.GetType();
      listTypeName = listType.Name;

      if (listType.IsGenericType)
      {
        var args = listType.GetGenericArguments();
        if (args.Length > 0 && listTypeName.Contains("`1"))
            listTypeName = listTypeName.Replace("`1", "<" + args[0].Name + ">");
      }
    }

    private static bool ListSupportsListChanged(IEnumerable list)
    {
      if (list == null)
        throw new ArgumentNullException("list");

      if (list is IBindingList)
        return true;
      var listChanged = list.GetType().GetEvent("ListChanged");
      return (listChanged != null && listChanged.EventHandlerType == typeof (ListChangedEventHandler));
    }

    private static string MakeTooltip(IEnumerable<string> properties)
    {
      var sb = new StringBuilder();
      var first = true;
      foreach (var t in properties)
      {
        if (first)
        {
          sb.Append(t);
          first = false;
        }
        else
          sb.AppendFormat(", {0}", t);
      }

      return sb.ToString();
    }

    private static List<string> GetPropertyChangedEvents(Type itemType)
    {
      if (itemType == null)
        throw new ArgumentNullException("itemType");

      return (from prop in itemType.GetProperties()
              let propChangedEvent = itemType.GetEvent(prop.Name + "Changed")
              where propChangedEvent != null && propChangedEvent.EventHandlerType == typeof (EventHandler)
              select prop.Name).ToList();
    }

    private void buttonAnalysis_Click(object sender, EventArgs e)
    {
      var dlg = new AnalysisForm(listItemTypeName,
                                 listTypeName,
                                 iEditableObject,
                                 iNotifyPropertyChanged,
                                 propertyChangeEvents,
                                 listChanged,
                                 iRaiseItemChangedEvents,
                                 view.List.IsReadOnly,
                                 view.List.IsFixedSize,
                                 synced);
      dlg.ShowDialog();
    }
  }
}