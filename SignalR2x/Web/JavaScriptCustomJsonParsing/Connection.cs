using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Web.JavaScriptCustomJsonParsing
{
    public class Connection : PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Send(connectionId, String.Format("You sent me '{0}'", data));
        }
    }
}