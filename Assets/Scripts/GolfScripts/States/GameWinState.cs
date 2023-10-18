using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameWinState : GameState
    {
        public MainMenuState mainMenuState;
        public LevelController levelController;
        public AudioSource audioSource;

        protected override void OnEnable()
        {
            base.OnEnable();
            audioSource.Play();
        }


        public void Restart()
        {
            levelController.ClearStones();
            audioSource.Stop();
            GameEvents.RestartGame();

            Exit();
            mainMenuState.Enter();
        }
    }
}
