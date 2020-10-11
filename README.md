# BepInEx basic plugin template

This is a basic template for writing BepInEx 5.3 plugins.  
The template comes preconfigured with the following components:

* **BepInEx.Core 5.3** - The core BepInEx library that contains all important core API.
* **HarmonyX 2.0.6** - Harmony fork that is used in BepInEx. With this you can patch game functions at runtime.
* **BepInEx.Analyzers 1.0.1** - Helper Roslyn analyzers for BepInEx.
* **UnityEngine.Core 5.6.0** - Stubbed UnityEngine 5.6 core library. This is usable for game-independent BepInEx plugins. For game plugin development, you should replace this with `UnityEngine.dll` of the game you're modding.
* **Microsoft.Unity.Analyzers 1.8.2** - A collection of Roslyn analyzers for generic Unity programming.

The template targets .NET Framework 3.5 which is usable for game-independent plugin development. For game-specific development, [target a more specific version](#change-net-api-version)

## Getting started

To get started, copy this repository as a template. You can do one of the following:

* [Use this repository as GitHub repo template](https://docs.github.com/en/free-pro-team@latest/github/creating-cloning-and-archiving-repositories/creating-a-repository-from-a-template)
* [Clone or download this repository](https://docs.github.com/en/free-pro-team@latest/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
* [Install `dotnet` template from releases](https://github.com/BepInEx/BepInEx.PluginTemplate/releases)

After downloading, open `BepInExPlugin.sln` in your IDE of choice and build.
The generated plugin DLL will be placed into `src/bin/(Debug|Releate)/net35` folder. 
You can place the generate plugin into `BepInEx/plugins` folder and use it.

## Repository structure

Some notable parts of the repository are

* `.template.config` - used only for dotnet template generation, can be removed.
* `BepInExPlugin.sln` - the solution file of the project. Can be opened in an IDE like Visual Studio or Rider.
* `nuget.config` - configuration for NuGet. Used to specify a link for a custom NuGet feed that contains BepInEx packages.
* `src` - the folder with the plugin source code.
    * `*.cs` - the source code files of the plugin.
	* `BepInExPlugin.csproj` - the project file that contains configuration for building the code.

## Change .NET API version

By default this repo uses .NET Framework 3.5 and references UnityEngine from Unity 5.6. While usable for general plugin development, game-specific plugins need to reference the correct .NET API version.

To change the version, simply open `BepInExPlugin.csproj` in a text editor and change

```xml
<TargetFramework>net35</TargetFramework>
```

To a different version. Currently, the following targets are usable with Unity:

* `net35`
* `net46`
* `netstandard2.0`

Check the [Creating solution section](https://bepinex.github.io/bepinex_docs/master/articles/dev_guide/plugin_tutorial/1_setup.html#creating-a-solution) of BepInEx plugin development guide for information on which version to choose.

In addition, you may need to reference the correct UnityEngine library from the game. To do that, remove `UnityEngine.Core` NuGet package and instead add reference to `UnityEngine.dll` (and `UnityEngine.CoreModule.dll` if needed) to the project. You can find such DLLs in the game's `Managed` folder.

## Documentation, guides and more

For more guides, refer to [BepInEx wiki](https://bepinex.github.io/bepinex_docs/master/articles/index.html).  
If you're writing a BepInEx plugin for the first time, [check out the plugin development walkthrough](https://bepinex.github.io/bepinex_docs/master/articles/dev_guide/plugin_tutorial/index.html).