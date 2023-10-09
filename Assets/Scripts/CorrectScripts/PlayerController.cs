using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CorrectScene
{
    public class PlayerController : MonoBehaviour
    {
        public Spawner spawner;
        public CloudController cloudController;
        public List<Villager> villagers;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                spawner.Spawn();
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                cloudController.Action();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var villager in villagers)
                {
                    villager.ChangeTool();
                }
            }
        }
    }
}

