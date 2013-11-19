using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Web.HubProgress
{
    public class ProgressHub : Hub
    {
        public async Task<string> DoLongRunningThing(IProgress<int> progress)
        {
            for (int i = 0; i <= 100; i+=5)
            {
                await Task.Delay(200);
                progress.Report(i);
            }

            return "Job complete!";
        }
    }
}