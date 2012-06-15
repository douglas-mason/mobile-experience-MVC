using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using mobile_experience_MVC.Models;

namespace mobile_experience_MVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            Database.SetInitializer(new StageDBInitializer());

            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }

    public class StageDBInitializer : DropCreateDatabaseIfModelChanges<StageDB>
    {
        protected override void Seed(StageDB context)
        {
            base.Seed(context);

            context.StageAEEvents.Add(new StageAEEvent
            {
                Id = "1",
                Artist = "Maroon 5",
                Date = "5/26/2012",
                Time = "8:00",
                Venue = "Monroeville"
            });
            context.StageAEEvents.Add(new StageAEEvent
            {
                Id = "2",
                Artist = "Rihanna",
                Date = "6/15/2012",
                Time = "7:00",
                Venue = "North Shore"
            });
            context.StageAEEvents.Add(new StageAEEvent
            {
                Id = "3",
                Artist = "LMFAO",
                Date = "7/4/2012",
                Time = "6:00",
                Venue = "North Shore"
            });
        }
    }
}