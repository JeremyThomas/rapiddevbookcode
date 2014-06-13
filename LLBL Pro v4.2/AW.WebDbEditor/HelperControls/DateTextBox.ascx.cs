using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Date textbox which contains 3 textboxes, one for day, one for month and one for year, to overcome the lack of a simple dropdown datepicker control
/// in ASP.NET (to avoid using 3rd party controls).
/// </summary>
[ValidationProperty("Text")]
public partial class HelperControls_DateTextBox : System.Web.UI.UserControl
{
	#region Class Member Declarations
	private bool _required = false;
	#endregion

	protected void Page_Load(object sender, EventArgs e)
	{
		if(!_required)
		{
			tbxMonth.CssClass = "text";
			tbxYear.CssClass = "text";
			tbxDay.CssClass="text";
		}
	}


	/// <summary>
	/// Produces the date value.
	/// </summary>
	/// <returns>the datetime value represented by this control's contents.</returns>
	private Nullable<DateTime> ProduceDateValue()
	{
		if(!(valDay.IsValid && valMonth.IsValid && valYear.IsValid))
		{
			// already not valid
			return null;
		}

		int month = 0;
		int day = 0;
		int year = 0;

		if(!int.TryParse(tbxMonth.Text, out month))
		{
			// failed
			return null;
		}
		if(!int.TryParse(tbxDay.Text, out day))
		{
			// failed
			return null;
		}
		if(!int.TryParse(tbxYear.Text, out year))
		{
			// failed
			return null;
		}

		try
		{
			DateTime date = new DateTime(year, month, day);
			return date;
		}
		catch
		{
			// something went wrong
			return null;
		}
	}



	/// <summary>
	/// Determines whether this instance is valid.
	/// </summary>
	/// <returns>
	/// 	true if this control contains a correct date, otherwise it returns false.
	/// </returns>
	public bool IsValid()
	{
		Nullable<DateTime> dateValue = ProduceDateValue();
		return dateValue.HasValue;
	}

	#region Class Properties
	/// <summary>
	/// Gets or sets a value indicating whether this <see cref="Controls_DateTextBox"/> is required.
	/// </summary>
	/// <value><c>true</c> if required; otherwise, <c>false</c>.</value>
	public bool Required
	{
		get
		{
			return _required;
		}
		set
		{
			_required = value;
		}
	}


	/// <summary>
	/// Gets / Sets the value for this control. 
	/// </summary>
	public Nullable<DateTime> Value
	{
		get
		{
			Nullable<DateTime> toReturn = ProduceDateValue();
			if(_required && !toReturn.HasValue)
			{
				toReturn = DateTime.MinValue;
			}
			return toReturn;
		}
		set
		{
			if(value.HasValue)
			{
				tbxMonth.Text = value.Value.Month.ToString();
				tbxDay.Text = value.Value.Day.ToString();
				tbxYear.Text = value.Value.Year.ToString();
			}
		}
	}
	
	
	/// <summary>
	/// Gets the value as text, which means it will return the date in short date format. If the date is invalid, it will return an empty string. 
	/// Use this property for validators. Use the Value property for obtaining the value. 
	/// </summary>
	public string Text
	{
		get
		{
			Nullable<DateTime> toReturn = ProduceDateValue();
			if(toReturn.HasValue)
			{
				return toReturn.Value.ToShortDateString();
			}
			else
			{
				return string.Empty;
			}
		}
	}
	
	
	/// <summary>
	/// Gets or sets a value indicating whether this control is readonly.
	/// </summary>
	public bool ReadOnly
	{
		get { return tbxMonth.ReadOnly;}
		set
		{
			tbxMonth.ReadOnly = true;
			tbxDay.ReadOnly = true;
			tbxYear.ReadOnly = true;
		}
	}
	#endregion
}
