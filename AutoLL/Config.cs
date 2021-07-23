using Exiled.API.Interfaces;
using System.ComponentModel;

namespace AutoLL
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin Enabled? - Accepts Bool (Def: true)")]
        public bool IsEnabled { get; set; } = true;

        [Description("The MINIMUM number of players required for the lobby to unlock allowing the round to start - Accepts Whole Values from 1 to Max (Def: 4)")]
        public int MinPlayersToStart { get; set; } = 4;
    }
}
