using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UsersViewer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "API",
                url: "{api}/{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional },
                namespaces: new String[] { "UsersViewer.API" },
                constraints: new { api = "api" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Users", action = "Index", id = UrlParameter.Optional },
                namespaces: new String[] { "UsersViewer.Controllers" }
            );
        }
    }
}
