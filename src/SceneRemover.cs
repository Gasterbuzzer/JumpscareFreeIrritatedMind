using MelonLoader;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Class/Namespace for removing any scene objects 

namespace EasyIrritatedMind.src
{
    public class SceneRemover
    {

        public static void handleSceneChange(string sceneName)
        {
            switch (sceneName)
            {
                case "nachalo":
                    CheapJumpscareNachaloRemover();
                    break;
                default:
                    MelonLogger.Msg($"Info: New scene {sceneName} loaded. No changes applied here.");
                    break;
            }

        }

        public static void CheapJumpscareNachaloRemover()
        {
            
            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                if (gameObj != null && gameObj.name == "Cube (15)")
                {
                    // Enter room first time jumpscare
                    if (gameObj.GetComponent<TriggerAnimation>() != null)
                    {
                        // We found the cube

                        // We disable the sound, since its loud and aua
                        gameObj.GetComponent<UnityEngine.AudioSource>().mute = true;
                        gameObj.GetComponent<UnityEngine.AudioSource>().playOnAwake = true;
                        gameObj.GetComponent<UnityEngine.AudioSource>().volume = 0.0f;


                        // We also enable the light, since its dark and scary
                        GameObject.Find("123").transform.GetChild(0).gameObject.SetActive(true);
                        GameObject.Find("123").gameObject.GetComponent<Animation>().enabled = false;

                        // Disable the scary jumpscare man
                        GameObject.Find("Cube.007 (2345345").gameObject.SetActive(false);
                    }
                }

                // Second less spooky jumpscare sound
                if (gameObj != null && gameObj.name == "Cube (4)")
                {
                    if (gameObj.GetComponent<TriggerAnimation>() != null)
                    {
                        //GameObject.Destroy(gameObj);
                        gameObj.GetComponent<UnityEngine.AudioSource>().mute = true;
                        gameObj.GetComponent<UnityEngine.AudioSource>().playOnAwake = true;
                        gameObj.GetComponent<UnityEngine.AudioSource>().volume = 0.0f;
                    }
                }

                // Second hidden man removed
                if (gameObj != null && gameObj.name == "Cube.007 (1)")
                {
                    if (gameObj.GetComponent<Animation>() != null)
                    {
                        gameObj.GetComponent<Animation>().enabled = false;
                        gameObj.GetComponent<SkinnedMeshRenderer>().enabled = false;
                    }
                }
            }

        }
    }
}
