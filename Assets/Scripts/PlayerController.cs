using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestLab
{
    public class PlayerController : MonoBehaviour
    {
        public List<GameObject> villagers;

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                foreach(var village in villagers)
                {
                    village.gameObject.GetComponent<Villager>().ChangeTool(); 
                }
            }
        }
    }
}

