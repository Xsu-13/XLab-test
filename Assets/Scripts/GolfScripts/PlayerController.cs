
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void Start()
        {
            if(player == null)
            {
                Debug.Log("PlayerController: Player is null");
            }
        }

        public void onDown()
        {
            if (player != null)
                player.SetDown(true);
        }

        public void OnUp()
        {
            if (player != null)
                player.SetDown(false);
        }
    }
}

