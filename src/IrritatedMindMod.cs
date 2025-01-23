﻿using System;
using System.Collections;
using System.Reflection;
using EasyIrritatedMind.src;
using MelonLoader;
using Steamworks;
using UnityEngine;

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
            LoggerInstance.Msg($"EasyIrritatedMind Mod has successfully loaded!");
        }

        // For removing jumpscares
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            SceneRemover.handleSceneChange(sceneName);
        }

        // Cheats for faster testing
        public override void OnLateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                GameObject.Find("FirstPerson-AIO").GetComponent<FirstPersonAIO>().SetWalkingSpeed(15f);
            }
        }
    }


    // Annoying Bird: Numbers
    [HarmonyLib.HarmonyPatch(typeof(LazyDaisy), "checkNum", new Type[] { typeof(lazyDaisyButton) })]
    public static class PatchBirdCheckAlwaysCorrect
    {

        /// <summary>
        /// Patches the Bird to always accept any input as correct.
        /// </summary>
        /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
        /// <param name="__instance"> Caller of function. </param>
        /// <param name="lazyDaisyButton"> Lazy Daisy Button Pressed </param>
        private static void Prefix(MethodBase __originalMethod, object __instance, ref lazyDaisyButton lazyDaisyButton)
        {
            lazyDaisyButton.rightButton = true;
        }
    }

    // Disable Jumpscare
    [HarmonyLib.HarmonyPatch(typeof(GameEnd), "GameOver", new Type[] { typeof(GameEnd.DeathReason) })]
    public static class PatchJumpscareGone
    {

        /// <summary>
        /// Patches the jump scare class to skip the jump scare and to just proceeed.
        /// </summary>
        /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
        /// <param name="__instance"> Caller of function. </param>
        /// <param name="reason"> Reason for death. </param>
        private static bool Prefix(GameEnd __instance, MethodBase __originalMethod, ref GameEnd.DeathReason reason)
        {
            // We redo what the original code does but without playing the jumpscare

            // Use reflection to access the private stopwatchActive field

            // Get Class type of GameEnd
            Type gameEndType = __originalMethod.DeclaringType;

            var stopwatchActive = gameEndType.GetField("stopwatchActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            if (stopwatchActive != null)
            {
                stopwatchActive.SetValue(__instance, false);
            }
            else
            {
                MelonLogger.Error("Failed to access the member 'stopwatchActive' of GameEnd.");
                return false;
            }

            // Mute audio incase the jumpscare makes sound

            var muteAudiosMethod = gameEndType.GetMethod("MuteAudios", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null);
            muteAudiosMethod.Invoke(__instance, null);

            __instance.jumpscare.targetCameraAlpha = 1.0f;
            //__instance.jumpscare.gameObject.SetActive(true); // maybe we don't enable it. Lets leave it off. No reason, no, didn't get scared.

            // Lets also not allow the switch to switch, so that it won't auto load the scare.


            // Switch the tips for the end screen, basically replace any this, to the __instance  (Basically the same since the class is not static)

            // Now we check if they had an upgrade and if they survived.
            // This is unforunate, or else we could have skipped the jumpscare function by just calling the DeathCoroutine.
            // Here would be the jumpscare play: this.jumpscare.Play();

            // We first get the private member shieldWasUsed
            var shieldWasUsed = gameEndType.GetField("shieldWasUsed", BindingFlags.NonPublic | BindingFlags.Instance);

            if (shieldWasUsed == null) // Sanity Check
            {
                MelonLogger.Error("Failed to access the member 'shieldWasUsed' of GameEnd.");
                return false;
            }

            // We also need to get the DeathCoroutine to actually call it.
            var DeathCoroutineUncallable = gameEndType.GetMethod("DeathCoroutine", BindingFlags.NonPublic | BindingFlags.Instance);

            if (DeathCoroutineUncallable == null) // Sanity Check
            {
                MelonLogger.Error("Failed to access the coroutine 'DeathCoroutine' of GameEnd.");
                return false;
            }

            IEnumerator DeathCoroutineIEnumerator = (IEnumerator)DeathCoroutineUncallable.Invoke(__instance, null);

            if (DeathCoroutineUncallable == null) // Sanity Check
            {
                MelonLogger.Error("Failed to convert the coroutine 'DeathCoroutine' to a IEnumerator.");
                return false;
            }

            // Get Value with the given instance and casting it to boolean
            if (!(bool)shieldWasUsed.GetValue(__instance) && __instance.ShieldUpgradeEnabled && UnityEngine.Random.Range(0, 100) < 15)
            {
                // Setting the shield was used to true
                shieldWasUsed.SetValue(__instance, true);

                __instance.DelayedCanvasAnimation.ExecuteDelayed(1.8f);

                // Changed to use SteamClient from SteamWorks, not that is changes anything significantly
                if (!SteamClient.IsValid)
                    SteamClient.Init(2644400U);
                new Steamworks.Data.Achievement("proknulo").Trigger();
                SteamUserStats.StoreStats();
                return false;
            }
            else
            {
                if (!SteamClient.IsValid)
                    SteamClient.Init(2644400U);
                new Steamworks.Data.Achievement("first_death").Trigger();
                SteamUserStats.StoreStats();

                // Changed to MelonLoaders Coroutines to ensure max safety.
                //__instance.StartCoroutine(__instance.DeathCoroutine());
                MelonLoader.MelonCoroutines.Start(DeathCoroutineIEnumerator);
                return false;
            }
        }
    }
}
