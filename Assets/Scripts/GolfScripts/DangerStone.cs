using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class DangerStone : Stone
    {
        private void Start()
        {
            isDanger = true;
            Invoke("DestroyStone", 4f);
        }

        private void DestroyStone()
        {
            Destroy(gameObject);
        }
    }
}
