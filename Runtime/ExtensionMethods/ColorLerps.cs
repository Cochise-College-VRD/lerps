using System.Collections;
using UnityEngine;

namespace Cochise.Lerps
{
    public static class ColorLerps
    {
        public static IEnumerator LerpMaterialColor(this Material mat, Color c1, Color c2, float duration)
        {
            float elapsedTime = 0f;
            
            while (elapsedTime < duration)
            {
                Color currentColor = Color.Lerp(c1, c2, elapsedTime / duration);
                mat.color = currentColor;
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }

        public static IEnumerator LerpLightColor(this Light l, Color c1, Light c2, float duration)
        {
            float elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                Color currColor = Color.Lerp(c1, c2, elapsedTime / duration);
                l.color = currColor;
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }
    }
}
