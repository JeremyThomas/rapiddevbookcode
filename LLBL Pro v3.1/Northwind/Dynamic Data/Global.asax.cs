﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using System.Web.Routing;
using System.Web.DynamicData;

namespace Dynamic_Data
{
	public class Global : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			MetaModel model = new MetaModel();

			//                    IMPORTANT: DATA MODEL REGISTRATION 
			// Uncomment this line to register the LLBLGen Pro selfservicing project for 
			// for ASP.NET Dynamic Data. Set ScaffoldAllTables = true only if you are sure 
			// that you want all tables in the data model to support a scaffold (i.e. templates) 
			// view. To control scaffolding for individual tables, create a partial class for 
			// the entity and apply the [Scaffold(true)] attribute to the partial class.
			ContextConfiguration config = new ContextConfiguration();

			// Set ScaffoldAllTables = true if you are sure that you want all your tables to support a scaffold (i.e. templated) view.
			config.ScaffoldAllTables = true;

			// Define the model provider. You've to specify the type of the DataAccessAdapter to use and the type of the generated EntityType enum below.
			// An example is given in the commented out lines below. Uncomment the lines below and adjust the namespaces for the DataAccessAdapter type,
			// the EntityType enum, the LinqMetaData type and the ElementCreator type. 

			SD.LLBLGen.Pro.DynamicDataSupportClasses.LLBLGenProDataModelProvider modelProvider =
							 new SD.LLBLGen.Pro.DynamicDataSupportClasses.LLBLGenProDataModelProvider(
										 typeof(Northwind.DAL.SqlServer.DataAccessAdapter),	
										 typeof(Northwind.DAL.EntityType),							
										 new Northwind.DAL.Linq.LinqMetaData(),					
										 new Northwind.DAL.FactoryClasses.ElementCreator());		

			// register the modelprovider with the model so DynamicData knows how the model looks like 
			model.RegisterContext(modelProvider, config);

			// register the datamodelprovider in the application object so it's retrievable in the datasources.
			HttpContext.Current.Application.Add(SD.LLBLGen.Pro.DynamicDataSupportClasses.Constants.DataModelProviderKey, modelProvider);

			// The following statement supports separate-page mode, where the List, Detail, Insert, and 
			// Update tasks are performed by using separate pages. To enable this mode, uncomment the following 
			// route definition, and comment out the route definitions in the combined-page mode section that follows.
			routes.Add(new DynamicDataRoute("{table}/{action}.aspx")
			{
				Constraints = new RouteValueDictionary(new { action = "List|Details|Edit|Insert" }),
				Model = model
			});

			// The following statements support combined-page mode, where the List, Detail, Insert, and
			// Update tasks are performed by using the same page. To enable this mode, uncomment the
			// following routes and comment out the route definition in the separate-page mode section above.
			//routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
			//    Action = PageAction.List,
			//    ViewName = "ListDetails",
			//    Model = model
			//});

			//routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
			//    Action = PageAction.Details,
			//    ViewName = "ListDetails",
			//    Model = model
			//});
		}

		void Application_Start(object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

	}
}
