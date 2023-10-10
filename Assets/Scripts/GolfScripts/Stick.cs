using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Golf
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onCollision;

        private void OnCollisionEnter(Collision collider)
        {
            onCollision.Invoke(collider.collider);
        }
    }
}

