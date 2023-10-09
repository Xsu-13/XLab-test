using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CorrectScene
{
    public class Spawner : MonoBehaviour
    {
        public GameObject[] prefabs;

        public void Spawn()
        {
            var prefab = GetRandomPrefab();

            if (prefab == null)
            {
                Debug.LogWarning("Spawner: prefab == null");
                return;
            }

            Instantiate(prefab, transform.position, Quaternion.identity);

        }

        GameObject GetRandomPrefab()
        {
            if (prefabs.Length == 0)
            {
                Debug.LogWarning("Spawner: prefabs list is emplty");
                return null;
            }

            int index = Random.Range(0, prefabs.Length);
            return prefabs[index];
        }
    }
}

