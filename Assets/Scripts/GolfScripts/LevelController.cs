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
        public float defaultMaxDelay = 2f;
        public float delayMin = 0.5f;
        public float delayStep = 0.1f;
        private float m_delay;
        public int score { get; private set; } = 0;
        public int highScore;

        public int scoreToWin;

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
            GameEvents.onWin += IncreaseScoreToWin;
            ResetDelay();
        }
        private void OnDisable()
        {
            StopAllCoroutines();
            GameEvents.onStickHit -= AddScore;
        }

        public void IncreaseScoreToWin()
        {
            scoreToWin = scoreToWin * 3 / 2;
        }

        private void AddScore()
        {
            score++;
            //highScore = Mathf.Max(highScore, score);
            if (score == scoreToWin)
                GameEvents.Win();
        }

        private void ResetDelay()
        {
            m_delay = defaultMaxDelay;
            delayMax = defaultMaxDelay;
        }

        private void RefreshDelay()
        {
            m_delay = Random.Range(delayMin, delayMax);
            delayMax = Mathf.Max(delayMin, delayMax-delayStep);
        }

    }
}

