using System.Collections;
using System.Collections.Generic;
using UnityEditor.Graphs;
using UnityEngine;

namespace Cochise.Lerps
{
    public static class LightLerps
    {
        public static IEnumerator LerpIntensity(this Light light, float targetIntensity, float duration)
        {
            float elapsedTime = Time.deltaTime;
            float startingIntensity = light.intensity;

            while(elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                light.intensity = Mathf.Lerp(startingIntensity, targetIntensity, elapsedTime / duration);
                yield return null;
            }
        }
    }
}
