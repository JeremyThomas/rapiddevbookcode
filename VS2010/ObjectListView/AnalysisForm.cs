using System.Text;
using System.Windows.Forms;
using JesseJohnston.Properties;

namespace JesseJohnston
{
  internal partial class AnalysisForm : Form
  {
    private readonly string listType;
    private readonly string listItemType;
    private readonly bool iEditableObject;
    private readonly bool iNotifyPropertyChanged;
    private readonly bool propertyChangeEvents;
    private readonly bool listChanged;
    private readonly bool iRaiseItemChangedEvents;
    private readonly bool readOnly;
    private readonly bool fixedSize;
    private readonly bool synced;

    public AnalysisForm()
    {
      InitializeComponent();
    }

    public AnalysisForm(string listItemTypeName,
                        string listTypeName,
                        bool listItemsIEditableObject,
                        bool listItemsINotifyPropertyChanged,
                        bool listItemsPropertyChangedEvents,
                        bool listListChanged,
                        bool listIRaiseItemChangedEvents,
                        bool listReadOnly,
                        bool listFixedSize,
                        bool listSynced)
      : this()
    {
      listItemType = listItemTypeName;
      listType = listTypeName;
      iEditableObject = listItemsIEditableObject;
      iNotifyPropertyChanged = listItemsINotifyPropertyChanged;
      propertyChangeEvents = listItemsPropertyChangedEvents;
      listChanged = listListChanged;
      iRaiseItemChangedEvents = listIRaiseItemChangedEvents;
      readOnly = listReadOnly;
      fixedSize = listFixedSize;
      synced = listSynced;
    }

    protected override void OnCreateControl()
    {
      base.OnCreateControl();

      richTextBox.Rtf = GenerateAnalysisText();
    }

    protected override void OnLayout(LayoutEventArgs levent)
    {
      base.OnLayout(levent);

      if (Created)
        buttonClose.Left = ClientSize.Width/2 - buttonClose.Width/2;
    }

    private string GenerateAnalysisText()
    {
      var sb = new StringBuilder();

      sb.Append(Resources.analysisColorFontHeader);
      sb.Append(Resources.analysisHeaderText);

      if (iEditableObject && iNotifyPropertyChanged)
      {
        sb.AppendFormat(Resources.analysisListItemOptimal, listItemType);
        sb.Append(Resources.analysisListItemSupportsINotifyPropertyChanged);
        sb.Append(Resources.analysisListItemSupportsIEditableObject);
      }
      else
      {
        sb.AppendFormat(Resources.analysisListItemSubOptimal, listItemType);

        if (iNotifyPropertyChanged)
          sb.Append(Resources.analysisListItemSupportsINotifyPropertyChanged);
        else if (propertyChangeEvents)
          sb.Append(Resources.analysisListItemNoINotifyPropertyChanged);
        else
          sb.Append(Resources.analysisListItemNoINotifyPropertyChangedNoPropertyChangedEvents);

        if (iEditableObject)
          sb.Append(Resources.analysisListItemSupportsIEditableObject);
        else
          sb.Append(Resources.analysisListItemNoIEditableObject);
      }

      if (listChanged && iRaiseItemChangedEvents)
      {
        sb.AppendFormat(Resources.analysisListOptimal, listType);
        sb.Append(Resources.analysisListSupportsListChanged);
        sb.Append(Resources.analysisListSupportsIRaiseItemChangedEvents);
      }
      else
      {
        sb.AppendFormat(Resources.analysisListSubOptimal, listType);

        if (listChanged)
          sb.Append(Resources.analysisListSupportsListChanged);
        else
          sb.Append(Resources.analysisListNoListChanged);

        if (iRaiseItemChangedEvents)
          sb.Append(Resources.analysisListSupportsIRaiseItemChangedEvents);
        else
          sb.Append(Resources.analysisListNoIRaiseItemChangedEvents);
      }

      sb.Append(Resources.analysisListModifications);
      if (!readOnly && !fixedSize)
        sb.Append(Resources.analysisListWritableVariableSize);
      else if (readOnly)
        sb.Append(Resources.analysisListReadOnly);
      else if (fixedSize)
        sb.Append(Resources.analysisListWritableFixedSize);

      sb.Append(Resources.analysisListThreadSafety);
      if (synced)
        sb.Append(Resources.analysisListSynced);
      else
        sb.Append(Resources.analysisListNotSynced);

      if (!iEditableObject || !iNotifyPropertyChanged || !listChanged || !iRaiseItemChangedEvents)
      {
        sb.Append(Resources.analysisRecommendations);

        if (!iNotifyPropertyChanged)
          sb.Append(Resources.analysisRecommendationsINotifyPropertyChanged);
        if (!iEditableObject)
          sb.Append(Resources.analysisRecommendationsIEditableObject);
        if (!listChanged)
          sb.Append(Resources.analysisRecommendationsListChanged);
        if (!iRaiseItemChangedEvents)
          sb.Append(Resources.analysisRecommendationsIRaiseItemChangedEvents);
        if (!listChanged || !iRaiseItemChangedEvents)
          sb.Append(Resources.analysisRecommendationsBindingListT);
      }

      return sb.ToString();
    }
  }
}