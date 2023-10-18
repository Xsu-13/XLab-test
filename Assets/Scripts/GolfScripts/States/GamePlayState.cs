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
        public TMP_Text winScore;

        public GameState gameOverState;
        public GameState gameWinState;

        protected override void OnEnable()
        {
            base.OnEnable();
            controller.enabled = true;
            player.enabled = true;
            clip.Play();
            StickHit();

            GameEvents.onCollisionStones += OnGameOver;
            GameEvents.onStickHit += StickHit;
            GameEvents.onWin += OnWin;
        }

        private void StickHit()
        {
            score.text = $"Score: {controller.score}";
            winScore.text = $"Score to win: {controller.scoreToWin}";
        }

        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }

        private void OnWin()
        {
            Exit();
            gameWinState.Enter();
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

