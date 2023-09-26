using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cochise.Lerps
{
    public class ChangeMaterialColorOverTime : MonoBehaviour
    {
        
        [SerializeField]
        Color startColor = Color.white;
        [SerializeField]
        Color endColor = Color.white;
        [SerializeField]
        private float duration = 1f;


        private Material material;

        private void Awake()
        {
            material = GetComponent<Renderer>().material;
        }

        [ContextMenu("Change Color")]
        public void ChangeColor()
        {
            material.color = startColor;
            StartCoroutine(material.LerpMaterialColor(startColor, endColor, duration));
        }
    }
}
