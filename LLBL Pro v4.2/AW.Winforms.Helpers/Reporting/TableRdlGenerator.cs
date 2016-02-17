using System.Collections.Generic;
using Rdl;

namespace AW.Winforms.Helpers.Reporting
{
  /// <summary>
  ///   Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
  internal class TableRdlGenerator
  {
    public List<string> Fields { get; set; }

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
      var headerTableRows = new TableRowsType {TableRow = new[] {CreateHeaderTableRow()}};
      return headerTableRows;
    }

    private TableRowType CreateHeaderTableRow()
    {
      var headerTableRow = new TableRowType {Items = new object[] {CreateHeaderTableCells(), "0.25in"}};
      return headerTableRow;
    }

    private TableCellsType CreateHeaderTableCells()
    {
      var headerTableCells = new TableCellsType {TableCell = new TableCellType[Fields.Count]};
      for (var i = 0; i < Fields.Count; i++)
      {
        headerTableCells.TableCell[i] = CreateHeaderTableCell(Fields[i]);
      }
      return headerTableCells;
    }

    private TableCellType CreateHeaderTableCell(string fieldName)
    {
      var headerTableCell = new TableCellType {Items = new object[] {CreateHeaderTableCellReportItems(fieldName)}};
      return headerTableCell;
    }

    private ReportItemsType CreateHeaderTableCellReportItems(string fieldName)
    {
      var headerTableCellReportItems = new ReportItemsType {Items = new object[] {CreateHeaderTableCellTextbox(fieldName)}};
      return headerTableCellReportItems;
    }

    private static TextboxType CreateHeaderTableCellTextbox(string fieldName)
    {
      var headerTableCellTextbox = new TextboxType
      {
        Name = fieldName + "_Header",
        Items = new object[]
        {
          fieldName,
          CreateHeaderTableCellTextboxStyle(),
          true
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType14.Value,
          ItemsChoiceType14.Style,
          ItemsChoiceType14.CanGrow
        }
      };
      return headerTableCellTextbox;
    }

    private static StyleType CreateHeaderTableCellTextboxStyle()
    {
      var headerTableCellTextboxStyle = new StyleType
      {
        Items = new object[]
        {
          "700",
          "14pt"
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType5.FontWeight,
          ItemsChoiceType5.FontSize
        }
      };
      return headerTableCellTextboxStyle;
    }

    private DetailsType CreateDetails()
    {
      var details = new DetailsType {Items = new object[] {CreateTableRows()}};
      return details;
    }

    private TableRowsType CreateTableRows()
    {
      var tableRows = new TableRowsType {TableRow = new[] {CreateTableRow()}};
      return tableRows;
    }

    private TableRowType CreateTableRow()
    {
      var tableRow = new TableRowType {Items = new object[] {CreateTableCells(), "0.25in"}};
      return tableRow;
    }

    private TableCellsType CreateTableCells()
    {
      var tableCells = new TableCellsType {TableCell = new TableCellType[Fields.Count]};
      for (var i = 0; i < Fields.Count; i++)
      {
        tableCells.TableCell[i] = CreateTableCell(Fields[i]);
      }
      return tableCells;
    }

    private static TableCellType CreateTableCell(string fieldName)
    {
      var tableCell = new TableCellType {Items = new object[] {CreateTableCellReportItems(fieldName)}};
      return tableCell;
    }

    private static ReportItemsType CreateTableCellReportItems(string fieldName)
    {
      var reportItems = new ReportItemsType {Items = new object[] {CreateTableCellTextbox(fieldName)}};
      return reportItems;
    }

    private static TextboxType CreateTableCellTextbox(string fieldName)
    {
      var textbox = new TextboxType
      {
        Name = fieldName,
        Items = new object[]
        {
          "=Fields!" + fieldName + ".Value",
          CreateTableCellTextboxStyle(),
          true
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType14.Value,
          ItemsChoiceType14.Style,
          ItemsChoiceType14.CanGrow
        }
      };
      return textbox;
    }

    private static StyleType CreateTableCellTextboxStyle()
    {
      var style = new StyleType
      {
        Items = new object[]
        {
          "=iif(RowNumber(Nothing) mod 2, \"AliceBlue\", \"White\")",
          "Left"
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType5.BackgroundColor,
          ItemsChoiceType5.TextAlign
        }
      };
      return style;
    }

    private TableColumnsType CreateTableColumns()
    {
      var tableColumns = new TableColumnsType {TableColumn = new TableColumnType[Fields.Count]};
      for (var i = 0; i < Fields.Count; i++)
      {
        tableColumns.TableColumn[i] = CreateTableColumn();
      }
      return tableColumns;
    }

    private static TableColumnType CreateTableColumn()
    {
      var tableColumn = new TableColumnType {Items = new object[] {"2in"}};
      return tableColumn;
    }
  }
}