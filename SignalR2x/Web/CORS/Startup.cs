using System;
using System.Threading.Tasks;
using System.Web.Cors;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace Web
{
    public static class StartupCorsExtensions
    {
        private static Lazy<CorsOptions> _corsOptions = new Lazy<CorsOptions>(() =>
        {
            return new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = context =>
                    {
                        var policy = new CorsPolicy();
                        // Only allow CORS requests from the non-SSL version of my site
                        policy.Origins.Add("http://localhost:61200");
                        policy.AllowAnyMethod = true;
                        policy.AllowAnyHeader = true;
                        policy.SupportsCredentials = true;
                        return Task.FromResult(policy);
                    }
                }
            };
        });

        public static IAppBuilder MapSignalRWithCors(this IAppBuilder app)
        {
            return app.Map("/signalr", map =>
            {
                map.UseCors(_corsOptions.Value)
                   .RunSignalR(new HubConfiguration
                   {
                       // Enable JSONP to support cross-domain from IE <10 but be aware it's less secure than CORS
                       //EnableJSONP = true
                   });
            });
        }
    }
}
