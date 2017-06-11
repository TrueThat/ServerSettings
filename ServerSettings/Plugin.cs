using System.Linq;
using Steamworks;
using Rocket.Core.Plugins;
using Rocket.Core;
using Rocket.Core.Logging;

namespace ServerSettings
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance;

        protected override void Load()
        {
            Logger.Log("SS - Loading Server Settings! ( and memes :^) )");
            Instance = this;
            R.Plugins.OnPluginsLoaded += OnServerLoad;
        }
        protected override void Unload()
        {
            R.Plugins.OnPluginsLoaded -= OnServerLoad;
            base.Unload();
        }
        public void OnServerLoad()
        {
            if (Configuration.Instance.Enabled)
            {
                if (Configuration.Instance.ResetToDefault)
                {
                    SteamGameServer.SetKeyValue("rocketplugins", string.Join(",", R.Plugins.GetPlugins().Select(p => p.Name).ToArray()));
                }
                else
                {

                    if (Configuration.Instance.HideRocketPlugins)
                    {
                        SteamGameServer.SetKeyValue("rocketplugins", "");
                        Logger.Log("SS - Hidden Rocket Plugins! :^) ");
                    }
                    if (Configuration.Instance.ReplaceRocketPlugins)
                    {
                        SteamGameServer.SetKeyValue("rocketplugins", Configuration.Instance.CustomRocketPluginsText);
                        Logger.Log("SS - Replaced Rocket Plugins Text! :^) ");
                    }
                    if (Configuration.Instance.HideWorkshopItems)
                    {
                        SteamGameServer.SetKeyValue("Browser_Workshop_Count", "0");
                        Logger.Log("SS - Hidden Workshop Items! :^) ");
                    }
                    if (Configuration.Instance.ReplaceWorkshopItems)
                    {
                        SteamGameServer.SetKeyValue("Browser_Workshop_Count", Configuration.Instance.WorkshopLinesCount.ToString());
                        SteamGameServer.SetKeyValue("Browser_Workshop_Line", Configuration.Instance.CustomWorkshopItemsText);
                        Logger.Log("SS - Replaced Workshop Items Text! :^) ");
                    }
                    if (Configuration.Instance.HideConfigItems)
                    {
                        SteamGameServer.SetKeyValue("Browser_Config_Count", "0");
                        Logger.Log("SS - Hidden Config Items! :^) ");
                    }
                    if (Configuration.Instance.ReplaceConfigItems)
                    {
                        SteamGameServer.SetKeyValue("Browser_Config_Count", Configuration.Instance.ConfigLinesCount.ToString());
                        SteamGameServer.SetKeyValue("Browser_Config_Line", Configuration.Instance.CustomConfigItemsText);
                        Logger.Log("SS - Replace Config Items Text! :^) ");
                    }
                    if (Configuration.Instance.EnableCustomMapName)
                    {
                        SteamGameServer.SetMapName(Configuration.Instance.MapCustomName);
                        Logger.Log("SS - Set Map Name to (" + Configuration.Instance.MapCustomName + ") ! :^) ");
                    }
                    if (Configuration.Instance.EnableMaxPlayers)
                    {
                        SteamGameServer.SetMaxPlayerCount(Configuration.Instance.MaxServerPlayers);
                        Logger.Log("SS - Set Max players count to (" + Configuration.Instance.MaxServerPlayers + ") ! :^) ");
                    }
                    if (Configuration.Instance.EnableCustomServerName)
                    {
                        SteamGameServer.SetServerName(Configuration.Instance.ServerName);
                        Logger.Log("SS - Set Server Name to (" + Configuration.Instance.ServerName + ") ! :^) ");
                    }
                    Logger.Log("SS - Done!");
                }
            }
            else
            {
                Logger.Log("SS - Please Enable me in the Configuration in order for me to work :D!");
                Unload();
            }
        }
    }
}
