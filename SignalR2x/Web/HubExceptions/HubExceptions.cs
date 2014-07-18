using System;
using Microsoft.AspNet.SignalR;

namespace Web
{
    public class HubExceptions : Hub
    {
        public void ThrowsException()
        {
            throw new Exception("A very bad thing happened in my app.");
        }

        public void ThrowsHubException()
        {
            throw new HubException("You did something wrong.",
                errorData: "This is some more useful info about the error");
        }
    }
}