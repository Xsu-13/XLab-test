using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorrectScene
{
    public class Villager : MonoBehaviour
    {
        [SerializeField] List<GameObject> tools;

        private void Start()
        {
            ChangeTool();
        }

        public void ChangeTool()
        {
            if (tools.Count == 0)
            {
                Debug.Log("Villager: tools list is empty");
                return;
            }

            int index = Random.Range(0, tools.Count);
            SetActiveTool(index);
        }

        void SetActiveTool(int index)
        {
            for (int i = 0; i < tools.Count; i++)
            {
                tools[i].SetActive(i == index);
            }
        }
    }

}
