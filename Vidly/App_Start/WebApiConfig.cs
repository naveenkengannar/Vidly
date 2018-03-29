using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Vidly
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver=new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
