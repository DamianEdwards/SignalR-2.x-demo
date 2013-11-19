using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace Web.SendPreEncodedJson
{
    public class Connection : PersistentConnection
    {
        private static readonly byte[] _messageBytes = Encoding.UTF8.GetBytes(
            JsonConvert.SerializeObject(new
            {
                description = "This was serialized manually by me, SignalR didn't serialize it again.",
                aNumber = 1000,
                created = DateTime.UtcNow
            }));

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Send(connectionId, new ArraySegment<byte>(_messageBytes));
        }
    }
}