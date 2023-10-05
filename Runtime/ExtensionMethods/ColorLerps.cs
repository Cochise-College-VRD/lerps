using System.Collections;
using UnityEngine;

namespace Cochise.Lerps
{
    public static class ColorLerps
    {
        /// <summary>
        /// Lerps a material from one color to another
        /// over time.
        /// 
        /// NOTE: When trying to Lerp alpha channel
        /// ensure the material is set to "transparent"
        /// </summary>
        /// <param name="c1">Starting Color</param>
        /// <param name="c2">Ending Color</param>
        /// <param name="duration">Duration in seconds</param>
        /// <returns></returns>
        public static IEnumerator LerpColor(this Material mat, Color c1, Color c2, float duration)
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

        /// <summary>
        /// Lerps the color of a light over time.
        /// </summary>
        /// <param name="c1">Starting Color</param>
        /// <param name="c2">Ending Color</param>
        /// <param name="duration">Duration in seconds</param>
        /// <returns></returns>
        public static IEnumerator LerpColor(this Light l, Color c1, Color c2, float duration)
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

        public static IEnumerator LerpColor(this Light l, Color c1, float duration)
        {
            yield return l.LerpColor(l.color, c1, duration);
        }


    }
}
