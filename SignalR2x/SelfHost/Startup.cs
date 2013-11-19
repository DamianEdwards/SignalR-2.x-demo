using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Cors;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(SelfHost.Startup))]

namespace SelfHost
{
    public class Startup
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

        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.Map("/signalr", map =>
            {
                map.UseCors(_corsOptions.Value)
                   .RunSignalR(new HubConfiguration
                   {
                       // Enable JSONP to support cross-domain from IE <10 but be aware it's less secure than CORS
                       //EnableJSONP = true
                   });
            });

            // Turn tracing on programmatically
            GlobalHost.TraceManager.Switch.Level = SourceLevels.Information;

            app.UseWelcomePage();
        }
    }
}
