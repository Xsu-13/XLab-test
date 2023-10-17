using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public StoneSpawner spawner;
        public float delayMax = 2f;
        public float delayMin = 0.5f;
        public float delayStep = 0.1f;
        private float m_delay;
        public int score { get; private set; } = 0;
        public int highScore;

        private List<GameObject> m_stones = new List<GameObject>(16);

        private void Start()
        {
            RefreshDelay();
        }

        public void ClearStones()
        {
            foreach (var stone in m_stones)
                Destroy(stone);
            m_stones.Clear();
        }

        private IEnumerator SpawnStoneProc()
        {
            do
            {
                yield return new WaitForSeconds(m_delay);
                var stone = spawner.Spawn();
                m_stones.Add(stone); 
                RefreshDelay();

            } while (true);
        }
        private void OnEnable()
        {
            score = 0;
            StartCoroutine(SpawnStoneProc());
            GameEvents.onStickHit += AddScore;
        }
        private void OnDisable()
        {
            StopAllCoroutines();
            GameEvents.onStickHit -= AddScore;
        }

        private void AddScore()
        {
            score++;
            highScore = Mathf.Max(highScore, score);
        }

        private void RefreshDelay()
        {
            m_delay = Random.Range(delayMin, delayMax);
            delayMax = Mathf.Max(delayMin, delayMax-delayStep);
        }

    }
}

