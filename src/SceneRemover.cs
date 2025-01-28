using MelonLoader;
using UnityEngine;

// Class/Namespace for removing any scene objects 

namespace JumpsacreFreeIrritatedMind.src
{
    public class SceneRemover
    {

        public static void handleSceneChange(string sceneName)
        {
            switch (sceneName)
            {
                case "Demo_1 1":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    //CheapJumpscareDemo11Remover();
                    break;

                case "road 1":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareRoad1Remover();
                    break;

                case "nachalo":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareNachaloRemover();
                    break;

                case "nachalo 1":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareNachalo1Remover();
                    break;
                
                case "nachalo 2":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareNachalo2Remover();
                    break;

                case "nachalo 3":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareNachalo3Remover();
                    break;

                case "nachalo 5":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareNachalo5Remover();
                    break;

                case "market 1":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareMarket1Remover();
                    break;

                case "market 2":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareMarket2Remover();
                    break;

                case "Parents house 1":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareParentHouse1Remover();
                    break;

                case "Parents house 1 (2)":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).");
                    CheapJumpscareParentHouse1Number2Remover();
                    break;

                case "Parents house 3":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).\nBONUS: Lights were added.");
                    CheapJumpscareParentHouse3Remover();
                    break;

                case "Parents house 5":
                    MelonLogger.Msg($"Info: Scene {sceneName} loaded. Jumpscares and unwated noises have been removed successfully (Unless you see an error or warning).\nBONUS: Lights were added.");
                    CheapJumpscareParentHouse5Remover();
                    break;

                default:
                    MelonLogger.Msg($"Info: New scene {sceneName} loaded. No changes applied here.");
                    return;
            }

        }

        public static void CheapJumpscareRoad1Remover()
        {

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Jumpscare Button Press
                if (gameObj != null && gameObj.name == "Plane" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Door Kicking Volume reduced
                if (gameObj != null && gameObj.name == "door_kikcing" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().volume = 0.3f;
                }

                // Jumpscare Animatronics
                if (gameObj != null && gameObj.name == "GameObject" && gameObj.GetComponent<Animation>() != null)
                {
                    gameObj.GetComponent<Animation>().playAutomatically = false;

                    int childsOfJumpscare = gameObj.transform.childCount;

                    for (int i = 0; i < childsOfJumpscare; i++)
                    {
                        if (gameObj.transform.GetChild(i).name.Contains("untitled"))
                        {
                            GameObject.Destroy(gameObj.transform.GetChild(i).gameObject);
                        }
                    }
                }
            }
        }

        public static void CheapJumpscareParentHouse1Remover()
        {

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Jumpscare Button Press
                if (gameObj != null && gameObj.name == "jumpsc" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Combined Horror Reduce Sound
                if (gameObj != null && gameObj.name == "combinedHorror Variant" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().volume = 0.3f;
                }

                // Combined Horror Reduce Sound
                if (gameObj != null && gameObj.name == "combinedHorror Variant (3)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().volume = 0.3f;
                }

                // Combined Horror Reduce Sound
                if (gameObj != null && gameObj.name == "combinedHorror Variant (4)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().volume = 0.3f;
                }

                // Combined Horror Reduce Sound
                if (gameObj != null && gameObj.name == "combinedHorror Variant (1)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().volume = 0.3f;
                }
            }
        }

        public static void CheapJumpscareParentHouse5Remover()
        {

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Jumpscare Button Press
                if (gameObj != null && gameObj.name == "combinedHorror Variant" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;

                    gameObj.GetComponent<Animation>().enabled = false;
                    gameObj.GetComponent<Animation>().playAutomatically = false;
                    gameObj.GetComponent<Animation>().wrapMode = WrapMode.Default;

                    gameObj.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = false;
                    gameObj.transform.GetChild(2).GetComponent<AudioSource>().mute = true;
                    gameObj.transform.GetChild(2).GetComponent<AudioSource>().enabled = false;
                    gameObj.transform.GetChild(2).GetComponent<AudioSource>().volume = 0.0f;
                }

                // Combined Horror remove
                if (gameObj != null && gameObj.name == "Low_Poly_Male_body:Group2.003" && gameObj.GetComponent<SkinnedMeshRenderer>() != null)
                {
                    gameObj.GetComponent<SkinnedMeshRenderer>().enabled = false;
                }
            }
        }

        public static void CheapJumpscareNachalo3Remover()
        {
            // Whisper
            GameObject.Find("FirstPerson-AIO").transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<AudioSource>().enabled = false;
            GameObject.Find("FirstPerson-AIO").transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<AudioSource>().mute = true;
            GameObject.Find("FirstPerson-AIO").transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<AudioSource>().playOnAwake = false;
            GameObject.Find("FirstPerson-AIO").transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<AudioSource>().volume = 0.0f;

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Enable Cat
                if (gameObj != null && gameObj.name == "Cat" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.SetActive(true);
                }

            }
        }

        public static void CheapJumpscareNachalo5Remover()
        {
            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Enable Cat
                if (gameObj != null && gameObj.name == "Cat" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.SetActive(true);
                }

                // Enable Lights
                if(gameObj != null && gameObj.name == "123" && gameObj.GetComponent<Animation>() != null)
                {
                    gameObj.transform.GetChild(0).gameObject.SetActive(true);
                }

                // Scream from police eaten by monster
                if (gameObj != null && gameObj.name == "Audio Source (5)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().playOnAwake = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Glitch is too loud
                if (gameObj != null && gameObj.name == "Audio Source (7)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().playOnAwake = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Ambience too
                if (gameObj != null && gameObj.name == "Audio Source (6)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().playOnAwake = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Monster Activation
                if (gameObj != null && gameObj.name == "bebra actiovation" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().playOnAwake = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Monster
                if (gameObj != null && gameObj.name == "combinedHorror" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().playOnAwake = false;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;

                    // Animation
                    gameObj.GetComponent<Animation>().enabled = false;
                    gameObj.GetComponent<Animation>().playAutomatically = false;

                    // Movement
                    gameObj.GetComponent<AutoMoveAndRotate>().enabled = false;

                    // Monster actually existing
                    gameObj.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = false;
                    gameObj.transform.GetChild(1).GetComponent<BoxCollider>().enabled = false;
                }
            }
        }

        public static void CheapJumpscareNachalo2Remover()
        {
            // Jumpscare Bathroom
            GameObject.Find("DoorTrigger").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("door01_MDL_nar").GetComponent<AudioSource>().enabled = false;
        }

        public static void CheapJumpscareNachalo1Remover()
        {
            // Ambience noise
            GameObject.Find("Audio Source (1)").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Audio Source").GetComponent<AudioSource>().mute = true;
            GameObject.Find("Whishper").GetComponent<AudioSource>().enabled = false;

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Footsteps
                if (gameObj != null && gameObj.name == "GameObject (2)" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().enabled = false;
                }

                // Enable Lights in room
                if (gameObj != null && gameObj.name == "123" && gameObj.GetComponent<Animation>() != null)
                {
                    gameObj.transform.GetChild(0).gameObject.SetActive(true);
                }

                if (gameObj != null && gameObj.name == "FloorLamp.fbx_Scene" && gameObj.GetComponent<MeshRenderer>() != null)
                {
                    gameObj.transform.GetChild(0).gameObject.SetActive(true);
                    gameObj.transform.GetChild(0).gameObject.GetComponent<Light>().range = 25.0f;

                }
            }

        }

        public static void CheapJumpscareParentHouse1Number2Remover()
        {
            // Baby disable
            GameObject.Find("model").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("model").transform.GetChild(0).GetComponent<AudioSource>().enabled = false;

            // Jumpscare noise disable
            GameObject.Find("anim").GetComponent<AudioSource>().enabled = false;
        }

        public static void CheapJumpscareParentHouse3Remover()
        {
            // Destroy the SmokeEffects Particle System

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Creepy Atmosphere 1
                if (gameObj != null && gameObj.name == "SmokeEffect" && gameObj.GetComponent<AudioSource>() != null)
                {
                    GameObject.Destroy(gameObj);
                }
            }   
        }

        public static void CheapJumpscareMarket1Remover()
        {
            // Blood corner jumpscare
            GameObject.Find("screamer light").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Cube (14)").GetComponent<AudioSource>().enabled = false;

            // Door Jumpscare
            GameObject.Find("Cube.152 (1)").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Cube.152 (1)").GetComponent<AudioSource>().mute = true;
            GameObject.Find("Cube.152 (1)").GetComponent<AudioSource>().volume = 0.0f;
            GameObject.Find("Cube.152 (1)").transform.GetChild(0).GetChild(0).GetComponent<AudioSource>().enabled = false;
        }

        public static void CheapJumpscareMarket2Remover()
        {
            // Outside Monster be gone!
            GameObject.Find("Cube.013").GetComponent<SkinnedMeshRenderer>().enabled = false;

            GameObject.Find("audio (1)").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("audio (1)").GetComponent<AudioSource>().mute = true;
            GameObject.Find("audio (1)").GetComponent<AudioSource>().volume = 0.0f;

            // aaaa be gone!
            GameObject.Find("aaaa").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("aaaa").GetComponent<AudioSource>().mute = true;
            GameObject.Find("aaaa").GetComponent<AudioSource>().volume = 0.0f;

            // Horror Scream stay here!
            GameObject.Find("Cube.152 (1)").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Cube.152 (1)").GetComponent<AudioSource>().mute = true;
            GameObject.Find("Cube.152 (1)").GetComponent<AudioSource>().volume = 0.0f;

            // Footsteps are not welcome
            GameObject.Find("123").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("123").GetComponent<AudioSource>().mute = true;
            GameObject.Find("123").GetComponent<AudioSource>().volume = 0.0f;

            GameObject.Find("123").transform.GetChild(0).GetComponent<AudioSource>().enabled = false;
            GameObject.Find("123").transform.GetChild(0).GetComponent<AudioSource>().mute = true;
            GameObject.Find("123").transform.GetChild(0).GetComponent<AudioSource>().volume = 0.0f;

            // Creepy Music (Second Phase)
            GameObject.Find("music").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("music").GetComponent<AudioSource>().mute = true;
            GameObject.Find("music").GetComponent<AudioSource>().volume = 0.0f;

            // Enable normal music for best hearing
            GameObject.Find("music 1").GetComponent<AudioSource>().volume = 0.1f;

            // Player weird noise?
            GameObject.Find("Player Camera").GetComponent<AudioSource>().mute = true;
            GameObject.Find("Player Camera").GetComponent<AudioSource>().volume = 0.0f;
            GameObject.Find("Player Camera").GetComponent<AudioSource>().playOnAwake = false;
            GameObject.Find("Player Camera").GetComponent<AudioSource>().enabled = false;

            foreach (GameObject? gameObj in UnityEngine.GameObject.FindObjectsOfType<GameObject>(true))
            {
                // Creepy Atmosphere 1
                if (gameObj != null && gameObj.name == "audio" && gameObj.GetComponent<AudioSource>() != null)
                {
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                }

                // Remove Monster
                if (gameObj != null && gameObj.name == "combinedHorror" && gameObj.GetComponent<AudioSource>() != null)
                {

                    // First
                    // Animation parts
                    gameObj.GetComponent<Animation>().enabled = false;
                    gameObj.GetComponent<AutoMoveAndRotate>().enabled = false;

                    // Then Audio
                    gameObj.GetComponent<AudioSource>().enabled = false;
                    gameObj.GetComponent<AudioSource>().mute = true;
                    gameObj.GetComponent<AudioSource>().volume = 0.0f;
                    gameObj.GetComponent<AudioSource>().playOnAwake = false;

                    // Then the monster itself
                    gameObj.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = false;
                    gameObj.transform.GetChild(1).GetComponent<BoxCollider>().enabled = false;
                }
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
