using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using GameCore;
using Log = Exiled.API.Features.Log;

namespace AutoLL.Handlers
{
    public class PlayerEventHandlers
    {
        private readonly AutoLL plugin;
        public PlayerEventHandlers(AutoLL plugin) { this.plugin = plugin; }

        public void Verified(VerifiedEventArgs ev)
        {
            if (Player.List.Count() < plugin.Config.MinPlayersToStart && !RoundStart.LobbyLock)
            {
                RoundStart.LobbyLock = true;
                Log.Debug($"Server Player Count ({Player.List.Count()}) is Less than Configured ({plugin.Config.MinPlayersToStart}) - Lobby Lock Enabled", plugin.Config.EnableDebug);
            }
            else if (Player.List.Count() >= plugin.Config.MinPlayersToStart && RoundStart.LobbyLock)
            {
                RoundStart.LobbyLock = false;
                Log.Debug($"Server Player Count ({Player.List.Count()}) is Greater than or Equal to Configured ({plugin.Config.MinPlayersToStart}) - Lobby Lock Disabled", plugin.Config.EnableDebug);
            }
        }

        public void Left(LeftEventArgs ev)
        {

        }
    }
}
