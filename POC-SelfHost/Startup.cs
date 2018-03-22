using System.Web.Http;
using Owin;

namespace POC_SelfHost {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            // Attribute routing.
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }

    }
}
