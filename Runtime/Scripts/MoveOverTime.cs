using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Cochise.Lerps
{
    public class MoveOverTime : MonoBehaviour
    {
        [SerializeField]
        private Transform startPos;
        [SerializeField]
        private Transform endPos;
        [SerializeField]
        private float duration = 1f;

        [SerializeField]
        private bool useEvents = false;

        [SerializeField]
        private UnityEvent onStart;
        [SerializeField]
        private UnityEvent onEnd;

        [ContextMenu("Move")]
        public void Move()
        {
            if (useEvents)
            {
                StartCoroutine(MoveWithEvents());
            }
            else
            {
                StartCoroutine(this.transform.LerpPosition(startPos.position, endPos.position, duration));
            }
        }

        public IEnumerator MoveWithEvents()
        {
            onStart?.Invoke();
            yield return StartCoroutine(this.transform.LerpPosition(startPos.position, endPos.position, duration));
            onEnd?.Invoke();
        }

        
    }
}
