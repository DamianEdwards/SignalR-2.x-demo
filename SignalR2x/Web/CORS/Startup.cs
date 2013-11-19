using System;
using System.Threading.Tasks;
using System.Web.Cors;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

namespace Web
{
    public partial class Startup
    {
        public void CorsConfiguration(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {
                var corsOptions = new CorsOptions
                {
                    PolicyProvider = new CorsPolicyProvider
                    {
                        PolicyResolver = async context =>
                        {
                            var policy = new CorsPolicy();
                            // Only allow CORS requests from the non-SSL version of my site
                            policy.Origins.Add("http://localhost:61200");
                            policy.AllowAnyMethod = true;
                            policy.AllowAnyHeader = true;
                            policy.SupportsCredentials = true;
                            return policy;
                        }
                    }
                };
                
                map.UseCors(corsOptions)
                   .RunSignalR(new HubConfiguration
                   {
                       //EnableJSONP = true
                   });
            });
        }
    }
}
