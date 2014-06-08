using System.Collections.Generic;
using Rdl;

namespace AW.Winforms.Helpers.Reporting
{
  /// <summary>
  ///   Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
  internal class TableRdlGenerator
  {
    private List<string> m_fields;

    public List<string> Fields
    {
      get { return m_fields; }
      set { m_fields = value; }
    }

    public TableType CreateTable()
    {
      var table = new TableType
      {
        Name = "Table1", Items = new object[]
        {
          CreateTableColumns(),
          CreateHeader(),
          CreateDetails()
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType21.TableColumns,
          ItemsChoiceType21.Header,
          ItemsChoiceType21.Details
        }
      };
      return table;
    }

    private HeaderType CreateHeader()
    {
      var header = new HeaderType
      {
        Items = new object[]
        {
          CreateHeaderTableRows()
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType20.TableRows
        }
      };
      return header;
    }

    private TableRowsType CreateHeaderTableRows()
    {
      var headerTableRows = new TableRowsType();
      headerTableRows.TableRow = new[] {CreateHeaderTableRow()};
      return headerTableRows;
    }

    private TableRowType CreateHeaderTableRow()
    {
      var headerTableRow = new TableRowType();
      headerTableRow.Items = new object[] {CreateHeaderTableCells(), "0.25in"};
      return headerTableRow;
    }

    private TableCellsType CreateHeaderTableCells()
    {
      var headerTableCells = new TableCellsType();
      headerTableCells.TableCell = new TableCellType[m_fields.Count];
      for (var i = 0; i < m_fields.Count; i++)
      {
        headerTableCells.TableCell[i] = CreateHeaderTableCell(m_fields[i]);
      }
      return headerTableCells;
    }

    private TableCellType CreateHeaderTableCell(string fieldName)
    {
      var headerTableCell = new TableCellType();
      headerTableCell.Items = new object[] {CreateHeaderTableCellReportItems(fieldName)};
      return headerTableCell;
    }

    private ReportItemsType CreateHeaderTableCellReportItems(string fieldName)
    {
      var headerTableCellReportItems = new ReportItemsType();
      headerTableCellReportItems.Items = new object[] {CreateHeaderTableCellTextbox(fieldName)};
      return headerTableCellReportItems;
    }

    private TextboxType CreateHeaderTableCellTextbox(string fieldName)
    {
      var headerTableCellTextbox = new TextboxType();
      headerTableCellTextbox.Name = fieldName + "_Header";
      headerTableCellTextbox.Items = new object[]
      {
        fieldName,
        CreateHeaderTableCellTextboxStyle(),
        true
      };
      headerTableCellTextbox.ItemsElementName = new[]
      {
        ItemsChoiceType14.Value,
        ItemsChoiceType14.Style,
        ItemsChoiceType14.CanGrow
      };
      return headerTableCellTextbox;
    }

    private StyleType CreateHeaderTableCellTextboxStyle()
    {
      var headerTableCellTextboxStyle = new StyleType();
      headerTableCellTextboxStyle.Items = new object[]
      {
        "700",
        "14pt"
      };
      headerTableCellTextboxStyle.ItemsElementName = new[]
      {
        ItemsChoiceType5.FontWeight,
        ItemsChoiceType5.FontSize
      };
      return headerTableCellTextboxStyle;
    }

    private DetailsType CreateDetails()
    {
      var details = new DetailsType();
      details.Items = new object[] {CreateTableRows()};
      return details;
    }

    private TableRowsType CreateTableRows()
    {
      var tableRows = new TableRowsType();
      tableRows.TableRow = new[] {CreateTableRow()};
      return tableRows;
    }

    private TableRowType CreateTableRow()
    {
      var tableRow = new TableRowType();
      tableRow.Items = new object[] {CreateTableCells(), "0.25in"};
      return tableRow;
    }

    private TableCellsType CreateTableCells()
    {
      var tableCells = new TableCellsType();
      tableCells.TableCell = new TableCellType[m_fields.Count];
      for (var i = 0; i < m_fields.Count; i++)
      {
        tableCells.TableCell[i] = CreateTableCell(m_fields[i]);
      }
      return tableCells;
    }

    private TableCellType CreateTableCell(string fieldName)
    {
      var tableCell = new TableCellType();
      tableCell.Items = new object[] {CreateTableCellReportItems(fieldName)};
      return tableCell;
    }

    private ReportItemsType CreateTableCellReportItems(string fieldName)
    {
      var reportItems = new ReportItemsType();
      reportItems.Items = new object[] {CreateTableCellTextbox(fieldName)};
      return reportItems;
    }

    private TextboxType CreateTableCellTextbox(string fieldName)
    {
      var textbox = new TextboxType();
      textbox.Name = fieldName;
      textbox.Items = new object[]
      {
        "=Fields!" + fieldName + ".Value",
        CreateTableCellTextboxStyle(),
        true
      };
      textbox.ItemsElementName = new[]
      {
        ItemsChoiceType14.Value,
        ItemsChoiceType14.Style,
        ItemsChoiceType14.CanGrow
      };
      return textbox;
    }

    private StyleType CreateTableCellTextboxStyle()
    {
      var style = new StyleType();
      style.Items = new object[]
      {
        "=iif(RowNumber(Nothing) mod 2, \"AliceBlue\", \"White\")",
        "Left"
      };
      style.ItemsElementName = new[]
      {
        ItemsChoiceType5.BackgroundColor,
        ItemsChoiceType5.TextAlign
      };
      return style;
    }

    private TableColumnsType CreateTableColumns()
    {
      var tableColumns = new TableColumnsType();
      tableColumns.TableColumn = new TableColumnType[m_fields.Count];
      for (var i = 0; i < m_fields.Count; i++)
      {
        tableColumns.TableColumn[i] = CreateTableColumn();
      }
      return tableColumns;
    }

    private TableColumnType CreateTableColumn()
    {
      var tableColumn = new TableColumnType();
      tableColumn.Items = new object[] {"2in"};
      return tableColumn;
    }
  }
}