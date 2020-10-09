﻿using System.Reflection;
using BepInExPlugin;

#region Assembly attributes
/*
 * These attributes define various metainformation of the generated DLL.
 * In general, you don't need to touch these. Instead, edit the values in PluginInfo. 
 */
[assembly:AssemblyVersion(PluginInfo.PLUGIN_VERSION)]
[assembly:AssemblyTitle(PluginInfo.PLUGIN_NAME + " (" + PluginInfo.PLUGIN_ID + ")")]
[assembly:AssemblyProduct(PluginInfo.PLUGIN_NAME)]
#endregion

namespace BepInExPlugin
{
    /// <summary>
    /// The main metadata of the plugin.
    /// This information is used for BepInEx plugin metadata.
    /// </summary>
    /// <remarks>
    /// See also description of BepInEx metadata:
    /// https://bepinex.github.io/bepinex_docs/master/articles/dev_guide/plugin_tutorial/2_plugin_start.html#basic-information-about-the-plug-in
    /// </remarks>
    internal static class PluginInfo
    {
        /// <summary>
        /// Human-readable name of the plugin. In general, it should be short and concise.
        /// This is the name that is shown to the users who run BepInEx and to modders that inspect BepInEx logs. 
        /// </summary>
        public const string PLUGIN_NAME = "BepInEx Plugin";
        
        /// <summary>
        /// Unique ID of the plugin.
        /// This must be a unique string that contains only characters a-z, 0-9 underscores (_) and dots (.)
        /// Prefer using the reverse domain name notation: https://eqdn.tech/reverse-domain-notation/
        ///
        /// When creating Harmony patches, prefer using this ID for Harmony instances as well.
        /// </summary>
        public const string PLUGIN_ID = "org.bepinex.my.plugin";
        
        /// <summary>
        /// Version of the plugin. Must be in form <major>.<minor>.<build>.<revision>.
        /// Major and minor versions are mandatory, but build and revision can be left unspecified.
        /// </summary>
        public const string PLUGIN_VERSION = "1.0.0";
    }
}