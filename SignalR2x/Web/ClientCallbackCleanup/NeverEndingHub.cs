using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Web.ClientCallbackCleanup
{
    public class NeverEndingHub : Hub
    {
        private static TaskCompletionSource<object> _tcs = new TaskCompletionSource<object>();

        public Task NeverEnds()
        {
            return _tcs.Task;
        }
    }
}