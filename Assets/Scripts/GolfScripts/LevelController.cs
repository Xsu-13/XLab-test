using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public GameObject spawner;

        private void Start()
        {
            StartCoroutine(SpawnStoneProc());
        }

        private IEnumerator SpawnStoneProc()
        {
            float delay = 0.5f;
            do
            {
                yield return new WaitForSeconds(delay);
                spawner.gameObject.GetComponent<StoneSpawner>().Spawn();

            } while (true);

            yield return null;
        }

    }
}

