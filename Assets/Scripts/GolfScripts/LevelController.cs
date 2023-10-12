using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public GameObject spawner;
        public float delayMax = 2f;
        public float delayMin = 0.5f;
        public float delayStep = 0.1f;
        private float m_delay;
        public int score { get; private set; } = 0;

        private void Start()
        {
            StartCoroutine(SpawnStoneProc());
            RefreshDelay();
        }

        private IEnumerator SpawnStoneProc()
        {

            do
            {
                yield return new WaitForSeconds(m_delay);
                spawner.gameObject.GetComponent<StoneSpawner>().Spawn();
                RefreshDelay();

            } while (true);
        }
        private void OnEnable()
        {
            Player.OnStoneStickCollision += AddScore;
            Stone.onCollisionStone += GameOver;
        }
        private void OnDisable()
        {
            Player.OnStoneStickCollision -= AddScore;
            Stone.onCollisionStone -= GameOver;
        }

        private void GameOver()
        {
            Debug.Log("Game Over");
            enabled = false;
        }

        private void AddScore()
        {
            score++;
            Debug.Log($"Score: {score}");
        }

        private void RefreshDelay()
        {
            m_delay = Random.Range(delayMin, delayMax);
            delayMax = Mathf.Max(delayMin, delayMax-delayStep);
        }

    }
}

