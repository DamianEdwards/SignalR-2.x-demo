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