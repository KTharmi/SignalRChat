using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Note: 2
using Owin;
using Microsoft.Owin;
//Note :3
[assembly: OwinStartup(typeof(SignalRChat.Startup))]

namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Note: 4
            app.MapSignalR();
        }
    }
}