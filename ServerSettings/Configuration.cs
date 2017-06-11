using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;

namespace ServerSettings
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public bool HideRocketPlugins;
        public bool ReplaceRocketPlugins;
        public string CustomRocketPluginsText;
        public bool HideWorkshopItems;
        public bool ReplaceWorkshopItems;
        public string CustomWorkshopItemsText;
        public int WorkshopLinesCount;
        public bool HideConfigItems;
        public bool ReplaceConfigItems;
        public string CustomConfigItemsText;
        public int ConfigLinesCount;
        public bool EnableMaxPlayers;
        public int MaxServerPlayers;
        public bool EnableCustomServerName;
        public string ServerName;
        public bool EnableCustomMapName;
        public string MapCustomName;
        public bool ResetToDefault;

        public void LoadDefaults()
        {
            Enabled = true;
        }
    }
}
