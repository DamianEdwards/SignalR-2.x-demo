using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.StaticFiles.Filters;
using Owin;

[assembly: OwinStartup(typeof(Web.Startup))]

namespace Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<JavaScriptSendObjects.Connection>("/JavaScriptSendObjects/connection");
            app.MapSignalR<JavaScriptErrorHandling.Connection>("/JavaScriptErrorHandling/connection");
            app.MapSignalR<JavaScriptCustomJsonParsing.Connection>("/JavaScriptCustomJsonParsing/connection");

            app.MapSignalR();
            //app.MapSignalRWithCors();
        }
    }
}
