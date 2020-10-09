using BepInEx;

namespace BepInExPlugin
{
    /// <summary>
    /// This is the main plugin class that BepInEx injects and executes.
    /// This class provides MonoBehaviour methods and additional BepInEx-specific services like logging and
    /// configuration system.
    /// </summary>
    /// <remarks>
    /// BepInEx plugins are MonoBehaviours. Refer to Unity documentation for information on how to use various Unity
    /// events: https://docs.unity3d.com/Manual/class-MonoBehaviour.html
    ///
    /// To get started, check out the plugin writing walkthrough:
    /// https://bepinex.github.io/bepinex_docs/master/articles/dev_guide/plugin_tutorial/index.html
    /// </remarks>
    [BepInPlugin(PluginInfo.PLUGIN_ID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Insert code that runs once the plugin starts
        }
    }
}
