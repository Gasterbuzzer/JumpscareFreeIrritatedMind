using MelonLoader;
using System;
using System.Reflection;
using UnityEngine;

namespace JumpsacreFreeIrritatedMind.src
{
    public class DebugPatches
    {

        // onEnterActionOnTriggerEnter
        [HarmonyLib.HarmonyPatch(typeof(onEnterAction), "OnTriggerEnter", new Type[] { typeof(Collider) })]
        public static class PatchOnEnterActionEnterEventOnTriggerEnter
        {
            /// <summary>
            /// Patches the onEnterAction Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            /// <param name="other"> Collider that hit </param>
            private static bool Prefix(MethodBase __originalMethod, onEnterAction __instance, ref Collider other)
            {
                MelonLogger.Msg($"Triggered: Type is onEnterAction (OnTriggerEnter) (EnterEvent) and triggered by '{__instance.name}'");

                int amountEvents = __instance.EnterEvent.GetPersistentEventCount();

                if (amountEvents <= 0)
                {
                    return true; // No events
                }

                for (int i = 0; i < amountEvents; i++)
                {
                    MelonLogger.Msg($"Event Name: '{__instance.EnterEvent.GetPersistentMethodName(i)}'");
                    MelonLogger.Msg($"Event Target: '{__instance.EnterEvent.GetPersistentTarget(i)}'\n\n");
                }

                return true;
            }
        }

        // onEnterActionTrigger
        [HarmonyLib.HarmonyPatch(typeof(onEnterAction), "Trigger", new Type[] { })]
        public static class PatchOnEnterActionTrigger
        {
            /// <summary>
            /// Patches the onEnterAction Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            private static bool Prefix(MethodBase __originalMethod, onEnterAction __instance)
            {
                MelonLogger.Msg($"Triggered: Type is onEnterAction (Trigger) (EnterEvent) and triggered by '{__instance.name}'");

                int amountEvents = __instance.EnterEvent.GetPersistentEventCount();

                if (amountEvents <= 0)
                {
                    return true; // No events
                }

                for (int i = 0; i < amountEvents; i++)
                {
                    MelonLogger.Msg($"Event Name: '{__instance.EnterEvent.GetPersistentMethodName(i)}'");
                    MelonLogger.Msg($"Event Target: '{__instance.EnterEvent.GetPersistentTarget(i)}'\n\n");
                }

                return true;
            }
        }

        // onEnterActionOnTriggerExit
        [HarmonyLib.HarmonyPatch(typeof(onEnterAction), "OnTriggerExit", new Type[] { typeof(Collider) })]
        public static class PatchOnEnterActionExitEventOnTriggerExit
        {
            /// <summary>
            /// Patches the onEnterAction Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            /// <param name="other"> Collider that hit </param>
            private static bool Prefix(MethodBase __originalMethod, onEnterAction __instance, ref Collider other)
            {
                MelonLogger.Msg($"Triggered: Type is onEnterAction (OnTriggerExit) (ExitEvent) and triggered by '{__instance.name}'");

                int amountEvents = __instance.ExitEvent.GetPersistentEventCount();

                if (amountEvents <= 0)
                {
                    return true; // No events
                }

                for (int i = 0; i < amountEvents; i++)
                {
                    MelonLogger.Msg($"Event Name: '{__instance.ExitEvent.GetPersistentMethodName(i)}'");
                    MelonLogger.Msg($"Event Target: '{__instance.ExitEvent.GetPersistentTarget(i)}'\n\n");
                }

                return true;
            }
        }

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

        // onTriggerActionDelayed
        [HarmonyLib.HarmonyPatch(typeof(onTriggerActionDelayed), "ExecuteDelayed", new Type[] { typeof(float) })]
        public static class PatchOnTriggerActionDelayed
        {
            /// <summary>
            /// Patches the onTriggerActionDelayed Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            /// <param name="delay"> Delay before calling the action </param>
            private static bool Prefix(MethodBase __originalMethod, onTriggerActionDelayed __instance, ref float delay)
            {
                MelonLogger.Msg($"Triggered: Type is onTriggerActionDelayed and triggered by '{__instance.name}' with a delay of {delay}.");

                int amountEvents = __instance.Action.GetPersistentEventCount();

                if (amountEvents <= 0)
                {
                    return true; // No events
                }

                for (int i = 0; i < amountEvents; i++)
                {
                    MelonLogger.Msg($"Event Name: '{__instance.Action.GetPersistentMethodName(i)}'");
                    MelonLogger.Msg($"Event Target: '{__instance.Action.GetPersistentTarget(i)}'\n\n");
                }

                return true;
            }
        }

        // onVoidAction
        [HarmonyLib.HarmonyPatch(typeof(onVoidAction), "Execute", new Type[] { })]
        public static class PatchOnVoidAction
        {
            /// <summary>
            /// Patches the onVoidAction Class to reveal its trigger target.
            /// </summary>
            /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
            /// <param name="__instance"> Caller of function. </param>
            private static bool Prefix(MethodBase __originalMethod, onVoidAction __instance)
            {
                MelonLogger.Msg($"Triggered: Type is onVoidAction and triggered by '{__instance.name}'.");

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


        // TriggerAnimation
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
