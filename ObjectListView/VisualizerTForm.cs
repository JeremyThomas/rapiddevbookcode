using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JesseJohnston
{
  internal partial class VisualizerTForm<T> : Form
  {
    private ObjectListView<T> view;
    private string listTypeName;
    private string listItemTypeName;
    private bool iEditableObject;
    private bool iNotifyPropertyChanged;
    private bool propertyChangeEvents;
    private bool listChanged;
    private bool iRaiseItemChangedEvents;

    public ObjectListView<T> View
    {
      get { return view; }
      set
      {
        if (value == null)
          throw new ArgumentNullException("View");
        view = value;
      }
    }

    public VisualizerTForm()
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

      if (!view.List.IsReadOnly)
        labelReadOnly.Visible = false;

      foreach (ListSortDescription sort in view.SortDescriptions)
        listViewSort.Items.Add(new ListViewItem(new[] {sort.PropertyDescriptor.Name, sort.SortDirection.ToString()}));

      if (view.FilterPredicate == null)
        textBoxFilter.Text = view.Filter;
      else
        textBoxFilter.Text = "(FilterPredicate is in effect)";
    }

    private void ShowListItemProperties()
    {
      var listItemType = typeof (T);

      labelListItemType.Text = listItemTypeName;
      toolTip.SetToolTip(labelListItemType, listItemType.FullName);

      if (typeof (INotifyPropertyChanged).IsAssignableFrom(listItemType))
      {
        iNotifyPropertyChanged = true;
        labelINotifyPropertyChanged.Text = "Yes";
        labelINotifyPropertyChanged.ForeColor = Color.Green;
      }

      var notifyingProps = GetPropertyChangedEvents();
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

      if (typeof (IEditableObject).IsAssignableFrom(listItemType))
      {
        iEditableObject = true;
        labelIEditableObject.Text = "Yes";
        labelIEditableObject.ForeColor = Color.Green;
      }
    }

    private void ShowView()
    {
      var props = new List<PropertyDescriptor>();
      foreach (PropertyDescriptor prop in ((ITypedList) view).GetItemProperties(null))
        props.Add(prop);
      props.Sort(delegate(PropertyDescriptor desc1, PropertyDescriptor desc2) { return string.Compare(desc1.Name, desc2.Name, true); });

      // When deciding whether to use a DataGridTableStyle that we have provided, or to use the default table style, DataGrid
      // tries to match the MappingName of our table style against the list name.  If it doesn't match, the default table style
      // is used.  The mapping name of our table style is "", the default.  This matches the list name returned by ObjectListView's
      // implementation of ITypedList.GetListName().

      foreach (var prop in props)
      {
        var column = new DataGridTextBoxColumn();
        column.HeaderText = prop.Name;
        column.MappingName = prop.Name;
        column.NullText = "";
        column.ReadOnly = true;
        dataGridViewTableStyle.GridColumnStyles.Add(column);
      }

      dataGridView.DataSource = view;
    }

    private void ShowList()
    {
      var props = new List<PropertyDescriptor>();
      foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(typeof (T)))
        props.Add(prop);
      props.Sort(delegate(PropertyDescriptor desc1, PropertyDescriptor desc2) { return string.Compare(desc1.Name, desc2.Name, true); });

      // When deciding whether to use a DataGridTableStyle that we have provided, or to use the default table style, DataGrid
      // tries to match the MappingName of our table style against the list name.  If it doesn't match, the default table style
      // is used.  The logic below assigns the mapping name to mimic the way that the DataGrid list manager retrieves the name of the list.
      if (view.List is ITypedList)
        dataGridListTableStyle.MappingName = ((ITypedList) view.List).GetListName(null);
      else
        dataGridListTableStyle.MappingName = view.List.GetType().Name;

      foreach (var prop in props)
      {
        var column = new DataGridTextBoxColumn();
        column.HeaderText = prop.Name;
        column.MappingName = prop.Name;
        column.NullText = "";
        column.ReadOnly = true;
        dataGridListTableStyle.GridColumnStyles.Add(column);
      }

      dataGridList.DataSource = view.List;
    }

    private void GetTypeNames()
    {
      listItemTypeName = typeof (T).Name;

      var listType = view.List.GetType();
      listTypeName = listType.Name;

      if (listType.IsGenericType)
      {
        var args = listType.GetGenericArguments();
        if (args != null && args.Length > 0)
          if (listTypeName.Contains("`1"))
            listTypeName = listTypeName.Replace("`1", "<" + args[0].Name + ">");
      }
    }

    private bool ListSupportsListChanged(IList<T> list)
    {
      if (list == null)
        throw new ArgumentNullException("list");

      if (list is IBindingList)
        return true;
      else
      {
        var listChanged = list.GetType().GetEvent("ListChanged");
        return (listChanged != null && listChanged.EventHandlerType == typeof (ListChangedEventHandler));
      }
    }

    private string MakeTooltip(List<string> properties)
    {
      var sb = new StringBuilder();
      var first = true;
      for (var i = 0; i < properties.Count; i++)
      {
        if (first)
        {
          sb.Append(properties[i]);
          first = false;
        }
        else
          sb.AppendFormat(", {0}", properties[i]);
      }

      return sb.ToString();
    }

    private List<string> GetPropertyChangedEvents()
    {
      var events = new List<string>();

      var listItemType = typeof (T);
      foreach (var prop in listItemType.GetProperties())
      {
        var propChangedEvent = listItemType.GetEvent(prop.Name + "Changed");
        if (propChangedEvent != null && propChangedEvent.EventHandlerType == typeof (EventHandler))
          events.Add(prop.Name);
      }

      return events;
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
                                 false,
                                 false);
      dlg.ShowDialog();
    }
  }
}