using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.Mvc;
namespace NaoGuaZi.MvcExample12.Controllers
{
    public static class GlobalRoutesTable
    {
		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); 
			//default   routes
			routes.MapRoute(
				"Default",
				"{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				new string[] {"NaoGuaZi.MvcExample12.Controllers"}
			); 
		}
    }
}
