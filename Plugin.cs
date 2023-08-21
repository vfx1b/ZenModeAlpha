using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace ZenModeAlpha
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            var harmony = new Harmony("io.teamghost.zenmodealpha");

            harmony.PatchAll();
        }
    }
}
