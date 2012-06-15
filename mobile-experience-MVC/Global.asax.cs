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

           // routes.MapRoute(
            //    "Events", // Route name
              //  "{controller}/{action}/{id}", // URL with parameters
                //new { controller = "Events", action = "Details", id = UrlParameter.Optional } // Parameter defaults
            //);

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

            #region Events
            context.StageAEEvents.Add(new StageAEEvent
            {
                Id = 1,
                Artist = "Maroon 5",
                Date = "5/26/2012",
                Time = "8:00",
                Venue = "Monroeville"
            });
            context.StageAEEvents.Add(new StageAEEvent
            {
                Id = 2,
                Artist = "Rihanna",
                Date = "6/15/2012",
                Time = "7:00",
                Venue = "North Shore"
            });
            context.StageAEEvents.Add(new StageAEEvent
            {
                Id = 3,
                Artist = "LMFAO",
                Date = "7/4/2012",
                Time = "6:00",
                Venue = "North Shore"
            });
            #endregion
            #region Users
            context.Users.Add(new User
            {
                id = 100,
                email = "test100@test.com",
                password = "test100",
                userName = "tester100",
                relationships = "200, 300"
            });
            context.Users.Add(new User
            {
                id = 200,
                email = "test200@test.com",
                password = "test200",
                userName = "tester200",
                relationships = "100, 300"
            });
            context.Users.Add(new User
            {
                id = 300,
                email = "test300@test.com",
                password = "test300",
                userName = "tester300",
                relationships = "200, 400"
            });
            context.Users.Add(new User
            {
                id = 400,
                email = "test400@test.com",
                password = "test400",
                userName = "tester400",
                relationships = "100, 300"
            });
            #endregion
            #region UserEvents
            context.UserEvents.Add(new UserEvent
            {
                id = 10,
                eventId = 1,
                userId = 100
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 20,
                eventId = 2,
                userId = 200
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 30,
                eventId = 3,
                userId = 300
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 40,
                eventId = 1,
                userId = 200
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 50,
                eventId = 2,
                userId = 100
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 60,
                eventId = 3,
                userId = 200
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 70,
                eventId = 1,
                userId = 400
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 80,
                eventId = 2,
                userId = 400
            });
            context.UserEvents.Add(new UserEvent
            {
                id = 90,
                eventId = 3,
                userId = 400
            });
            #endregion
        }
    }
}