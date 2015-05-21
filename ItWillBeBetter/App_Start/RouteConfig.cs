using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ItWillBeBetter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "First",
                url: "First",
                defaults: new { controller = "First", action = "Data", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Second",
                url: "Second",
                defaults: new { controller = "Second", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
