using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class GridViewExportUtils
{
    /// <summary>
    /// Export the passed grid to a ms excel file.
    /// </summary>
    /// <param name="fileName">The file of the name. It should include the .xls extension.</param>
    /// <param name="gv">The GridView to export</param>
    public static void Export(string fileName, GridView gv)
    {
        /// prepare the response
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", fileName));
        HttpContext.Current.Response.ContentType = "application/ms-excel";
        HttpContext.Current.Response.Charset = "";
        HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.Default;
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        
        // create a form to contain the grid
        Table table = new Table();
        table.GridLines = gv.GridLines;

        // add the header row to the table
        if (gv.HeaderRow != null)
        {
            PrepareControlForExport(gv.HeaderRow);
            table.Rows.Add(gv.HeaderRow);
        }
        
        // add each of the data rows to the table
        foreach (GridViewRow row in gv.Rows)
        {
            PrepareControlForExport(row);
            table.Rows.Add(row);
        }

        // add the footer row to the table
        if (gv.FooterRow != null)
        {
            PrepareControlForExport(gv.FooterRow);
            table.Rows.Add(gv.FooterRow);
        }

        // render the table into the htmlwriter
        table.RenderControl(htw);

        // render the htmlwriter into the response
        HttpContext.Current.Response.Write(sw.ToString());
        HttpContext.Current.Response.End();
    }

    /// <summary>
    /// Prepare a control to be rendered in a excel-friendly fashion
    /// </summary>
    /// <param name="control">The control to prepare.</param>
    private static void PrepareControlForExport(Control control)
    {
        int i = 0;
        while (i < control.Controls.Count)
        {
            Control current = control.Controls[i];
            switch (current.GetType().ToString())
            {
                case ("System.Web.UI.WebControls.DataControlLinkButton"):
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl(((LinkButton) current).Text));
                    break;

                case ("System.Web.UI.WebControls.ImageButton"):
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl(((ImageButton) current).AlternateText));
                    break;

                case ("System.Web.UI.WebControls.HyperLink"):
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl(((HyperLink) current).Text));
                    break;

                case ("System.Web.UI.WebControls.DropDownList"):
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl(((DropDownList) current).SelectedItem.Text));
                    break;

                case ("System.Web.UI.WebControls.CheckBox"):
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl(((CheckBox) current).Checked.ToString()));
                    break;

            }

            // look deep into the control children
            if (current.HasControls())
            {
                PrepareControlForExport(current);
            }

            i++;
        }
    }
}
