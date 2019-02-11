using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ComputerStore.Logic
{
	public class RouteActions
	{
		public static void RegisterCustomRoutes(RouteCollection routes)
		{
			routes.MapPageRoute(
				"ProductsByCategoryRoute",
				"Category/{categoryName}",
				"~/ProductList.aspx"
			);
			routes.MapPageRoute(
				"ProductByNameRoute",
				"Product/{productName}",
				"~/ProductDetails.aspx"
			);
		}
	}
}