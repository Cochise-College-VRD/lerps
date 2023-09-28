using System.Collections;
using UnityEngine;

namespace Cochise.Lerps
{
    public static class Vector3Lerps
    {
        public static IEnumerator LerpPosition(this Transform t, Vector3 start, Vector3 end, float duration)
        {
            float elapsedTime = 0f;
            t.localPosition = start;


            while (elapsedTime < duration)
            {
                t.localPosition = Vector3.Lerp(start, end, elapsedTime / duration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }

        public static IEnumerator LerpPositionRelative(this Transform t, Vector3 offset, float duration)
        {
            float elapsedTime = 0f;
            Vector3 startPos = t.localPosition;
            Vector3 endPos = startPos + offset;

            yield return t.LerpPosition(startPos, endPos, elapsedTime / duration);
        }

        public static IEnumerator LerpRotation(this Transform t, Quaternion start, Quaternion end, float duration)
        {
            float elapsedTime = 0f;
            t.localRotation = start;

            while (elapsedTime < duration)
            {
                t.localRotation = Quaternion.Lerp(start, end,elapsedTime / duration);
                elapsedTime += Time.deltaTime;  
                yield return null;
            }
        }

        public static IEnumerator LerpRotation(this Transform t, Vector3 startEuler, Vector3 endEuler, float duration)
        {
            float elapsedTime = 0f;
            t.eulerAngles = startEuler;

            while (elapsedTime < duration)
            {
                t.eulerAngles = Vector3.Lerp(startEuler, endEuler, elapsedTime / duration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }

        public static IEnumerator LerpScale(this Transform t, Vector3 startScale, Vector3 endScale, float duration)
        {
            float elapsedTime = 0f;
            t.localScale = startScale;

            while (elapsedTime < duration)
            {
                t.localScale = Vector3.Lerp(startScale, endScale, elapsedTime / duration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }
    }
}
