using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.StronglyTypedHubs
{
    public interface IClient
    {
        void NewMessage(string message);
    }
}
