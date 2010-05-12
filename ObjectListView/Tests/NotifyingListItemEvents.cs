
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using System.Text;

namespace JesseJohnston.Tests
{
	public class NotifyingListItemEvents
	{
		private int intValue = -1;
		private string stringValue;
		private DateTime dateValue;

		public DateTime DateTimeValue
		{
			get { return dateValue; }
			set
			{
				dateValue = value;
				OnDateTimeValueChanged();
			}
		}
		public int IntegerValue
		{
			get { return intValue; }
			set
			{
				intValue = value;
				OnIntegerValueChanged();
			}
		}
		public string StringValue
		{
			get { return stringValue; }
			set
			{
				stringValue = value;
				OnStringValueChanged();
			}
		}

		public event EventHandler DateTimeValueChanged;
		public event EventHandler IntegerValueChanged;
		public event EventHandler StringValueChanged;

		public NotifyingListItemEvents()
		{
		}

		private void OnDateTimeValueChanged()
		{
			if (this.DateTimeValueChanged != null)
				this.DateTimeValueChanged(this, EventArgs.Empty);
		}
		private void OnIntegerValueChanged()
		{
			if (this.IntegerValueChanged != null)
				this.IntegerValueChanged(this, EventArgs.Empty);
		}
		private void OnStringValueChanged()
		{
			if (this.StringValueChanged != null)
				this.StringValueChanged(this, EventArgs.Empty);
		}
	}
}
#endif