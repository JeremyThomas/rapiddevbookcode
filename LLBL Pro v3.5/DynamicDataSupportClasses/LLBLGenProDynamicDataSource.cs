////////////////////////////////////////////////////////////////////////////////////////////////////////
// LLBLGen Pro is (c) 2002-2008 Solutions Design. All rights reserved.
// http://www.llblgen.com
// The sourcecode for the Dynamic Data Support classes has been made available to LLBLGen Pro licensees
// so they can modify, update and/or extend it. Distribution of this sourcecode in textual, non-compiled, 
// non-binary form to non-licensees is prohibited. Distribution of binary compiled versions of this 
// sourcecode to non-licensees has been granted under the following license.
////////////////////////////////////////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c)2002-2008 Solutions Design. All rights reserved.
// http://www.llblgen.com
// 
// The Dynamic Data Support classes library sourcecode is released to LLBLGen Pro licensees under the 
// following license:
// --------------------------------------------------------------------------------------------
// 
// Redistribution and use of the sourcecode in compiled, binary forms, with or without modification, 
// are permitted provided that the following conditions are met: 
//
// 1) Redistributions must reproduce the above copyright notice, this list of 
//    conditions and the following disclaimer in the documentation and/or other materials 
//    provided with the distribution. 
// 2) Redistribution of the sourcecode in textual, non-binary, non-compiled form is prohibited.
// 
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR 
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR 
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
//
// The views and conclusions contained in the software and documentation are those of the authors 
// and should not be interpreted as representing official policies, either expressed or implied, 
// of Solutions Design. 
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
//		- Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Security.Permissions;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI.WebControls;
using System.Web.DynamicData.ModelProviders;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.DynamicDataSupportClasses
{
	/// <summary>
	/// Selfservicing specific dynamic data source control, a specialization of the LLBLGenProDataSource class. 
	/// </summary>
	[Description("LLBLGen Pro Dynamic Data DataSource control for SelfServicing."),
	AspNetHostingPermission(SecurityAction.InheritanceDemand, Level = AspNetHostingPermissionLevel.Minimal),
	AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal),
	DefaultEvent("PerformSelect")]
	public class LLBLGenProDynamicDataSource : LLBLGenProDataSource, IDynamicDataSource
	{
		#region Events
		public event EventHandler<DynamicValidatorEventArgs> Exception;
		#endregion

		#region Class Member Declarations
		private DynamicDataSourceState _state;
		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProDynamicDataSource"/> class.
		/// </summary>
		public LLBLGenProDynamicDataSource()
			: base()
		{
			base.IgnoreNullValuedSelectParameters = true;
			_state = new DynamicDataSourceState();
		}


		/// <summary>
		/// Restores control-state information from a previous page request that was saved by the <see cref="M:System.Web.UI.Control.SaveControlState"></see> method.
		/// </summary>
		/// <param name="savedState">An <see cref="T:System.Object"></see> that represents the control state to be restored.</param>
		protected override void LoadControlState(object savedState)
		{
			object[] state = (object[])savedState;
			base.LoadControlState(state[0]);
			_state.LoadControlState(state);
		}


		/// <summary>
		/// Saves any server control state changes that have occurred since the time the page was posted back to the server.
		/// </summary>
		/// <returns>
		/// Returns the server control's current state. If there is no state associated with the control, this method returns null.
		/// </returns>
		protected override object SaveControlState()
		{
			object[] state = _state.SaveControlState();
			state[0] = base.SaveControlState();
			return state;
		}


		/// <summary>
		/// Sets the types in data source control.
		/// </summary>
		private void SetTypesInDataSourceControl()
		{
			_state.LoadDataModelProvider();
			if(this.EntityCollection == null)
			{
				IEntityFactory factory = (IEntityFactory)_state.DataModelProvider.EntityNameToEntityProvider[_state.EntitySetName].EntityFactoryToUse;
				this.EntityCollection= factory.CreateEntityCollection();
			}
		}

		#region Class Property Declarations
		/// <summary>
		/// Gets or sets a value indicating whether the where clause has to be autogenerated
		/// </summary>
		public bool AutoGenerateWhereClause
		{
			get
			{
				return true;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets the type of the context. Not used in LLBLGen Pro. 
		/// </summary>
		public Type ContextType
		{
			get
			{
				return typeof(object);
			}
			set
			{
				Type t = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether deletes are enabled.
		/// </summary>
		public bool EnableDelete
		{
			get
			{
				return this.DataContainerType == DataSourceDataContainerType.EntityCollection;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether inserts are enabled.
		/// </summary>
		public bool EnableInsert
		{
			get
			{
				return this.DataContainerType == DataSourceDataContainerType.EntityCollection;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether updates are enabled.
		/// </summary>
		public bool EnableUpdate
		{
			get
			{
				return this.DataContainerType == DataSourceDataContainerType.EntityCollection;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the entity set. This is a Linq to sql/ef term, and is equal to the entity name this datasource 
		/// will work on.
		/// </summary>
		public string EntitySetName
		{
			get
			{
				return _state.EntitySetName;
			}
			set
			{
				if(_state.EntitySetName != value)
				{
					_state.EntitySetName = value;
					SetTypesInDataSourceControl();
				}
			}
		}

		/// <summary>
		/// Gets or sets the where clause for the datasourcecontrol. Not used in LLBLGen Pro
		/// </summary>
		public string Where
		{
			get
			{
				return null;
			}
			set
			{
				string v = value;
			}
		}

		/// <summary>
		/// Gets the where parameter collection. These parameters are equal to the SelectParameters and are the set of parameters the datasource
		/// should base its filter on. 
		/// </summary>
		public ParameterCollection WhereParameters
		{
			get { return this.SelectParameters; }
		}
		#endregion
	}

	
	/// <summary>
	/// Adapter specific dynamic data source control, a specialization of the LLBLGenProDataSource2 class. 
	/// </summary>
	[Description("LLBLGen Pro Dynamic Data DataSource control for Adapter."),
	AspNetHostingPermission(SecurityAction.InheritanceDemand, Level = AspNetHostingPermissionLevel.Minimal),
	AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal),
	DefaultEvent("PerformSelect")]
	public class LLBLGenProDynamicDataSource2 : LLBLGenProDataSource2, IDynamicDataSource
	{
		#region Events
		public event EventHandler<DynamicValidatorEventArgs> Exception;
		#endregion

		#region Class Member Declarations
		private DynamicDataSourceState _state;
		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProDynamicDataSource2"/> class.
		/// </summary>
		public LLBLGenProDynamicDataSource2()
			: base()
		{
			base.IgnoreNullValuedSelectParameters = true;
			_state = new DynamicDataSourceState();
		}

		/// <summary>
		/// Restores control-state information from a previous page request that was saved by the <see cref="M:System.Web.UI.Control.SaveControlState"></see> method.
		/// </summary>
		/// <param name="savedState">An <see cref="T:System.Object"></see> that represents the control state to be restored.</param>
		protected override void LoadControlState(object savedState)
		{
			object[] state = (object[])savedState;
			base.LoadControlState(state[0]);
			_state.LoadControlState(state);
		}


		/// <summary>
		/// Saves any server control state changes that have occurred since the time the page was posted back to the server.
		/// </summary>
		/// <returns>
		/// Returns the server control's current state. If there is no state associated with the control, this method returns null.
		/// </returns>
		protected override object SaveControlState()
		{
			object[] state = _state.SaveControlState();
			state[0] = base.SaveControlState();
			return state;
		}
		

		/// <summary>
		/// Sets the types in data source control.
		/// </summary>
		private void SetTypesInDataSourceControl()
		{
			_state.LoadDataModelProvider();
			if(this.AdapterToUse == null)
			{
				this.AdapterTypeName = FieldUtilities.CreateFullTypeName(_state.DataModelProvider.AdapterType);
			}
			if(this.EntityCollection == null)
			{
				this.EntityFactoryTypeName = FieldUtilities.CreateFullTypeName(_state.DataModelProvider.EntityNameToEntityProvider[_state.EntitySetName].EntityFactoryToUse.GetType());
			}
		}

		#region Class Property Declarations
		/// <summary>
		/// Gets or sets a value indicating whether the where clause has to be autogenerated
		/// </summary>
		public bool AutoGenerateWhereClause
		{
			get
			{
				return true;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets the type of the context. Not used in LLBLGen Pro. 
		/// </summary>
		public Type ContextType
		{
			get
			{
				return typeof(object);
			}
			set
			{
				Type t = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether deletes are enabled.
		/// </summary>
		public bool EnableDelete
		{
			get
			{
				return this.DataContainerType==DataSourceDataContainerType.EntityCollection;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether inserts are enabled.
		/// </summary>
		public bool EnableInsert
		{
			get
			{
				return this.DataContainerType==DataSourceDataContainerType.EntityCollection;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether updates are enabled.
		/// </summary>
		public bool EnableUpdate
		{
			get
			{
				return this.DataContainerType==DataSourceDataContainerType.EntityCollection;
			}
			set
			{
				bool v = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the entity set. This is a Linq to sql/ef term, and is equal to the entity name this datasource 
		/// will work on.
		/// </summary>
		public string EntitySetName
		{
			get
			{
				return _state.EntitySetName;
			}
			set
			{
				if(_state.EntitySetName != value)
				{
					_state.EntitySetName = value;
					SetTypesInDataSourceControl();
				}
			}
		}

		/// <summary>
		/// Gets or sets the where clause for the datasourcecontrol. Not used in LLBLGen Pro
		/// </summary>
		public string Where
		{
			get
			{
				return null;
			}
			set
			{
				string v = value;
			}
		}

		/// <summary>
		/// Gets the where parameter collection. These parameters are equal to the SelectParameters and are the set of parameters the datasource
		/// should base its filter on. 
		/// </summary>
		public ParameterCollection WhereParameters
		{
			get { return this.SelectParameters; }
		}
		#endregion
	}


	/// <summary>
	/// bucket class for state containment for the datasourcecontrols. 
	/// </summary>
	internal class DynamicDataSourceState
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DynamicDataSourceState"/> class.
		/// </summary>
		public DynamicDataSourceState()
		{
			this.EntitySetName = string.Empty;
		}

		/// <summary>
		/// Loads the state of the control.
		/// </summary>
		/// <param name="controlState">State of the control.</param>
		internal void LoadControlState(object[] controlState)
		{
			this.EntitySetName = (string)controlState[1];
		}


		/// <summary>
		/// Saves the state of the control.
		/// </summary>
		/// <returns></returns>
		internal object[] SaveControlState()
		{
			object[] state = new object[2];
			state[1] = this.EntitySetName;
			return state;
		}

		/// <summary>
		/// Loads the data model provider into this state object
		/// </summary>
		internal void LoadDataModelProvider()
		{
			if(this.DataModelProvider == null)
			{
				this.DataModelProvider = (LLBLGenProDataModelProvider)HttpContext.Current.Application[Constants.DataModelProviderKey];
			}
		}

		/// <summary>
		/// Gets or sets the name of the entity set.
		/// </summary>
		internal string EntitySetName { get; set; }
		/// <summary>
		/// Gets or sets the type of the context.
		/// </summary>
		internal Type ContextType { get; set; }
		/// <summary>
		/// Gets or sets the data model provider.
		/// </summary>
		internal LLBLGenProDataModelProvider DataModelProvider { get; set; }
	}
}
