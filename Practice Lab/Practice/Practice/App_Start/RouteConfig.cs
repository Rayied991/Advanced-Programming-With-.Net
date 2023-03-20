using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Practice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //request comes here then it goes to controller
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Portfolio", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
