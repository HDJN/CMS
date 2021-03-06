﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "StaticPages",
                url: "{action}",
                defaults: new { controller = "Home", id = UrlParameter.Optional },
                constraints: new { action = "Index|AboutUs|Contact|" }
            );

            routes.MapRoute(
                name: "CMSPages",
                url: "pages/{action}/{id}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CatchAll",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Router"}
            );



            //routes.MapRoute(
            //    name: "Default",
            //    url: "{action}/{id}",
            //    defaults: new { controller = "Home", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    "CatchAll",
            //    "{*url}",
            //    new { controller = "Home", action = "Router", pageName =  }
            //    );

            //routes.MapRoute(
            //    name: "Router",
            //    url: "{pageName}/{param1}/{param2}",
            //    defaults: new
            //    {
            //        controller = "Home",
            //        action = "Router",
            //        pageName = "Index",
            //        param1 = UrlParameter.Optional,
            //        param2 = UrlParameter.Optional
            //    }
            //);


            //routes.MapRoute(
            //    name: "Default",
            //    url: "{action}/{param1}/{param2}",
            //    defaults: new { controller = "Home", param1 = UrlParameter.Optional, param2 = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    "CatchAll",
            //    "{*url}",
            //    new { controller = "Home", action = "Router" }
            //    );

            //routes.MapRoute(
            //    name: "Router_with_subpages",
            //    url: "{page}/{subpage}",
            //    defaults: new { controller = "Home", action = "Router", id = UrlParameter.Optional }
            //);
        }
    }
}
