using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GamePlayState : GameState
    {
        public LevelController controller;
        public PlayerController player;


        protected override void OnEnable()
        {
            base.OnEnable();


            controller.enabled = true;
            player.enabled = true;
        }

        private void OnGameOver()
        {

        }

        protected override void OnDisable()
        {
            base.OnDisable();
            controller.enabled = false;
            player.enabled = false;
        }
    }
}

