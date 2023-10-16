using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public GameState gamePlayState;

        public void PlayGame()
        {
            Exit();
            gamePlayState.Enter();
        }
    }
}

