using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class ExplosionController : MonoBehaviour
    {
        private void Start()
        {
            Invoke("DestroyGameObject", 3f);
        }

        private void DestroyGameObject()
        {
            Destroy(gameObject);
        }
    }
}
