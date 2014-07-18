using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Web.Startup))]

namespace Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.Register(typeof(IUserIdProvider), () => new QueryStringUserIdProvider());

            app.MapSignalR<JavaScriptSendObjects.Connection>("/JavaScriptSendObjects/connection");
            app.MapSignalR<JavaScriptErrorHandling.Connection>("/JavaScriptErrorHandling/connection");
            app.MapSignalR<JavaScriptCustomJsonParsing.Connection>("/JavaScriptCustomJsonParsing/connection");
            app.MapSignalR<SendPreEncodedJson.Connection>("/SendPreEncodedJson/connection");
            
            app.MapSignalR();
            //app.MapSignalRWithCors();
        }

        public class QueryStringUserIdProvider : IUserIdProvider
        {
            public string GetUserId(IRequest request)
            {
                return request.QueryString["user"];
            }
        }
    }
}
