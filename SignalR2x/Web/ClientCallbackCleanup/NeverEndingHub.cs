using System.Threading.Tasks;
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