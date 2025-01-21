using System;
using EasyIrritatedMind.src;
using MelonLoader;

[assembly: MelonInfo(typeof(IrritatedMindMod), "IrritatedMindMod", "1.0.0", "Gasterbuzzer", "https://github.com/Gasterbuzzer/EasyIrritatedMind/releases/")]
[assembly: MelonGame("Burlaka Kyrylo", "Irritated Mind Fear of Warehouse")]
[assembly: MelonAuthorColor(ConsoleColor.Magenta)]
[assembly: MelonPriority(99)]

namespace EasyIrritatedMind.src
{

    public static class BuildInfo
    {
        public const string Name = "EasyIrritatedMind";
        public const string Description = "Mod for making the game easier.";
        public const string Author = "Gasterbuzzer";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = "https://github.com/Gasterbuzzer/EasyIrritatedMind/releases/";
    }

    public class IrritatedMindMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg($"Easy IrritatedMind Mod has been loaded!");
        }
    }
}
