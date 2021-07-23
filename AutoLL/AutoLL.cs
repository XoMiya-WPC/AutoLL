using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using AutoLL.Handlers;
using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace AutoLL
{
    public class AutoLL : Plugin<Config>
    {
        public override string Name
        {
            get
            {
                return "AutoLL";
            }
        }
            public override string Author
        {
            get
            {
                return "XoMiya-WPC";
            }
        }
       
        public override string Prefix { get; } = "Auto_Lobby_Lock";

        public override Version Version
        {
            get
            {
                return new Version(1, 0, 0);
            }
        }
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        private ServerEventHandlers server;
        private PlayerEventHandlers player;

        public override void OnEnabled()
        {
            Log.Info($"This Server Requires a minimum number of players to start - see port-config.yml for more info");
            server = new ServerEventHandlers(this);
            player = new PlayerEventHandlers(this);
            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Player.Verified += player.Verified;
            Player.Left += player.Left;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Server.WaitingForPlayers -= server.OnWaitingForPlayers;
            Player.Verified -= player.Verified;
            Player.Left -= player.Left;
            server = null;
            player = null;
        }
    }
}
