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
            HideRocketPlugins = false;
            ReplaceRocketPlugins = true;
            CustomRocketPluginsText = "THIS IS A ROCKET MEME";
            HideWorkshopItems = false;
            ReplaceConfigItems = true;
            CustomWorkshopItemsText = "THIS IS A WORKSHOP MEME";
            WorkshopLinesCount = 5;
            HideConfigItems = false;
            ReplaceConfigItems = true;
            CustomConfigItemsText = "THIS IS A CONFIG MEME";
            ConfigLinesCount = 5;
            EnableMaxPlayers = true;
            MaxServerPlayers = 12;
            EnableCustomServerName = true;
            ServerName = "THIS IS A SERVER MEME";
            EnableCustomMapName = true;
            MapCustomName = "MEMEP";
            ResetToDefault = false;
        }
    }
}
