using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using ComputerStore.Models;
using ComputerStore.Logic;

namespace ComputerStore
{
    public class Global : HttpApplication
    {
         void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

			// Initialize the product database.
			Database.SetInitializer(new ProductDatabaseInitializer());

			//власний користувач та роль
			RoleActions roleActions = new RoleActions();
			roleActions.AddUserAndRole();

			//добавляєм шляхи
			RouteActions.RegisterCustomRoutes(RouteTable.Routes);

		}
    }
}