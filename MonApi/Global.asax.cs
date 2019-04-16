using MonApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MonApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<MonApiContext>(new DropCreateDatabaseIfModelChanges<MonApiContext>());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
