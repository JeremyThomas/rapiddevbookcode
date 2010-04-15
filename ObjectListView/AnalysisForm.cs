// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JesseJohnston.Properties;

namespace JesseJohnston
{
	internal partial class AnalysisForm : Form
	{
		private string listType;
		private string listItemType;
		private bool iEditableObject;
		private bool iNotifyPropertyChanged;
		private bool propertyChangeEvents;
		private bool listChanged;
		private bool iRaiseItemChangedEvents;
		private bool readOnly;
		private bool fixedSize;
		private bool synced;

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
			this.listItemType = listItemTypeName;
			this.listType = listTypeName;
			this.iEditableObject = listItemsIEditableObject;
			this.iNotifyPropertyChanged = listItemsINotifyPropertyChanged;
			this.propertyChangeEvents = listItemsPropertyChangedEvents;
			this.listChanged = listListChanged;
			this.iRaiseItemChangedEvents = listIRaiseItemChangedEvents;
			this.readOnly = listReadOnly;
			this.fixedSize = listFixedSize;
			this.synced = listSynced;
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			this.richTextBox.Rtf = this.GenerateAnalysisText();
		}
		protected override void OnLayout(LayoutEventArgs levent)
		{
			base.OnLayout(levent);

			if (this.Created)
				this.buttonClose.Left = this.ClientSize.Width / 2 - this.buttonClose.Width / 2;
		}

		private string GenerateAnalysisText()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(Resources.analysisColorFontHeader);
			sb.Append(Resources.analysisHeaderText);

			if (this.iEditableObject && this.iNotifyPropertyChanged)
			{
				sb.AppendFormat(Resources.analysisListItemOptimal, this.listItemType);
				sb.Append(Resources.analysisListItemSupportsINotifyPropertyChanged);
				sb.Append(Resources.analysisListItemSupportsIEditableObject);
			}
			else
			{
				sb.AppendFormat(Resources.analysisListItemSubOptimal, this.listItemType);

				if (this.iNotifyPropertyChanged)
					sb.Append(Resources.analysisListItemSupportsINotifyPropertyChanged);
				else if (this.propertyChangeEvents)
					sb.Append(Resources.analysisListItemNoINotifyPropertyChanged);
				else
					sb.Append(Resources.analysisListItemNoINotifyPropertyChangedNoPropertyChangedEvents);

				if (this.iEditableObject)
					sb.Append(Resources.analysisListItemSupportsIEditableObject);
				else
					sb.Append(Resources.analysisListItemNoIEditableObject);
			}

			if (this.listChanged && this.iRaiseItemChangedEvents)
			{
				sb.AppendFormat(Resources.analysisListOptimal, this.listType);
				sb.Append(Resources.analysisListSupportsListChanged);
				sb.Append(Resources.analysisListSupportsIRaiseItemChangedEvents);
			}
			else
			{
				sb.AppendFormat(Resources.analysisListSubOptimal, this.listType);

				if (this.listChanged)
					sb.Append(Resources.analysisListSupportsListChanged);
				else
					sb.Append(Resources.analysisListNoListChanged);

				if (this.iRaiseItemChangedEvents)
					sb.Append(Resources.analysisListSupportsIRaiseItemChangedEvents);
				else
					sb.Append(Resources.analysisListNoIRaiseItemChangedEvents);
			}

			sb.Append(Resources.analysisListModifications);
			if (!this.readOnly && !this.fixedSize)
				sb.Append(Resources.analysisListWritableVariableSize);
			else if (this.readOnly)
				sb.Append(Resources.analysisListReadOnly);
			else if (this.fixedSize)
				sb.Append(Resources.analysisListWritableFixedSize);

			sb.Append(Resources.analysisListThreadSafety);
			if (this.synced)
				sb.Append(Resources.analysisListSynced);
			else
				sb.Append(Resources.analysisListNotSynced);

			if (!this.iEditableObject || !this.iNotifyPropertyChanged || !this.listChanged || !this.iRaiseItemChangedEvents)
			{
				sb.Append(Resources.analysisRecommendations);

				if (!this.iNotifyPropertyChanged)
					sb.Append(Resources.analysisRecommendationsINotifyPropertyChanged);
				if (!this.iEditableObject)
					sb.Append(Resources.analysisRecommendationsIEditableObject);
				if (!this.listChanged)
					sb.Append(Resources.analysisRecommendationsListChanged);
				if (!this.iRaiseItemChangedEvents)
					sb.Append(Resources.analysisRecommendationsIRaiseItemChangedEvents);
				if (!this.listChanged || !this.iRaiseItemChangedEvents)
					sb.Append(Resources.analysisRecommendationsBindingListT);
			}

			return sb.ToString();
		}
	}
}