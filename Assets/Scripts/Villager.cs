using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TestLab
{
    public class Villager : MonoBehaviour
    {
        public List<GameObject> tools;

        private void Start()
        {
            var index = Random.Range(0, tools.Count);
            tools[index].gameObject.SetActive(true);
        }
        public void ChangeTool()
        {
            HideTools();
            var index = Random.Range(0, tools.Count);
            tools[index].gameObject.SetActive(true);
        }


        void HideTools()
        {
            for(int i = 0; i<tools.Count; i++)
            {
                tools[i].gameObject.SetActive(false);
            }
        }
    }
}

