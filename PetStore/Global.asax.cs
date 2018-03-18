using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using PetStore.Models;
using System.Web.Mvc;
using PetStore.Logic;

namespace PetStore
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new MancareDatabaseInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig2.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig2.RegisterBundles(BundleTable.Bundles);

            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();
        }
    }
}