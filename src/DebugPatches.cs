using MelonLoader;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace EasyIrritatedMind.src
{
    public class DebugPatches
    {

        // onTriggerAction
        [HarmonyLib.HarmonyPatch(typeof(onTriggerAction), "OnTriggerEnter", new Type[] { typeof(Collider) })]
        public static class PatchOnTriggerAction
        {
            /// <summary>
            /// Patches the onTriggerAction Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            /// <param name="other"> Collider that hit </param>
            private static bool Prefix(MethodBase __originalMethod, onTriggerAction __instance, ref Collider other)
            {
                MelonLogger.Msg($"Triggered: Type is {__instance.ActionToExecute.ToString()} and triggered by '{__instance.name}'");

                int amountEvents = __instance.ActionToExecute.GetPersistentEventCount();

                if (amountEvents <= 0)
                {
                    return true; // No events
                }

                for (int i = 0; i < amountEvents; i++)
                {
                    MelonLogger.Msg($"Event Name: '{__instance.ActionToExecute.GetPersistentMethodName(i)}'");
                    MelonLogger.Msg($"Event Target: '{__instance.ActionToExecute.GetPersistentTarget(i)}'\n\n");
                }

                return true;
            }
        }


        // TriggerAnimationTest
        [HarmonyLib.HarmonyPatch(typeof(TriggerAnimation), "OnTriggerEnter", new Type[] { typeof(Collider) })]
        public static class PatchTriggerAnimation
        {
            /// <summary>
            /// Patches the TriggerAnimation Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            /// <param name="other"> Collider that hit </param>
            private static bool Prefix(MethodBase __originalMethod, TriggerAnimation __instance, ref Collider other)
            {
                MelonLogger.Msg($"Triggered: Type is TriggerAnimation and triggered by '{__instance.name}'");

                if (__instance.AnimationObject != null)
                {
                    MelonLogger.Msg($"Event Name: '{__instance.AnimationObject.name}'");
                }
                if (__instance.AnimationSound != null)
                {
                    MelonLogger.Msg($"Event Sound Name: '{__instance.AnimationSound.name}'\n\n");
                }

                return true;
            }
        }
    }
}
