using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Web.StronglyTypedHubs
{
    public class StrongHub : Hub<IClient>
    {
        public void Send(string message)
        {
            Clients.All.NewMessage(message);
        }
    }
}