using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Web.SendToUser
{
    public class UserHub : Hub
    {
        public void Send(string user, string message)
        {
            Clients.User(user).newMessage(message);
        }
    }
}