﻿using System.Web;
using System.Web.Http;

namespace Swashbuckle.Dummy.WebHost
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            SwaggerConfig.Register(GlobalConfiguration.Configuration);            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
        }
    }
}