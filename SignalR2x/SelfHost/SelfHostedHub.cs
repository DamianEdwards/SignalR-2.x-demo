using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
