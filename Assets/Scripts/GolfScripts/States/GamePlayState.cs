using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class GamePlayState : GameState
    {
        public LevelController controller;
        public PlayerController player;
        public AudioSource clip;
        public TMP_Text score;
        public TMP_Text highScore;

        public GameState gameOverState;

        protected override void OnEnable()
        {
            base.OnEnable();
            controller.enabled = true;
            player.enabled = true;
            clip.Play();
            StickHit();

            GameEvents.onCollisionStones += OnGameOver;
            GameEvents.onStickHit += StickHit;
        }

        private void StickHit()
        {
            score.text = $"Score: {controller.score}";
            highScore.text = $"High score: {controller.highScore}";
        }

        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            controller.enabled = false;
            player.enabled = false;
            clip.Stop();

            GameEvents.onCollisionStones -= OnGameOver;
            GameEvents.onStickHit -= StickHit;
        }
    }
}

