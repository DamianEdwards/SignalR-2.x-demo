using Microsoft.AspNet.SignalR;

namespace SelfHost
{
    public class SelfHostedHub : Hub
    {
        public string HelloWorld()
        {
            return "Hello from self-host on http://localhost:61201";
        }
    }
}
