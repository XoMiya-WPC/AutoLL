using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLL.Handlers
{
    public class ServerEventHandlers
    {
        private readonly AutoLL plugin;
        public ServerEventHandlers(AutoLL plugin) { this.plugin = plugin; }

        public void OnWaitingForPlayers()
        {
            Log.Debug("Waiting For Players...", plugin.Config.EnableDebug);
           
        }

    }
}
