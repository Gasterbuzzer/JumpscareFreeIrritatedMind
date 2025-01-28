using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace JumpsacreFreeIrritatedMind.src
{
    public class LightHelper
    {
        public static void CreateLight(Vector3 position, float lightIntensity = 3.0f, float lightRange = 150.0f, Color? _lightColor = null, LightType? _lightType = null)
        {
            // Create a new GameObject to hold the light
            GameObject lightGameObject = new GameObject("Dynamic Light");

            // Add a Light component to the GameObject
            Light lightComp = lightGameObject.AddComponent<Light>();

            if (_lightColor == null)
            {
                _lightColor = UnityEngine.Color.white;
            }

            if (_lightType == null)
            {
                _lightType = LightType.Point;
            }

            // Configure the light properties
            lightComp.type = (LightType) _lightType;
            lightComp.color = (Color) _lightColor;
            lightComp.intensity = lightIntensity;

            lightComp.range = lightRange;

            lightComp.shadows = LightShadows.Soft;

            // Position the light at the specified point
            lightGameObject.transform.position = position;
        }
    }
}
