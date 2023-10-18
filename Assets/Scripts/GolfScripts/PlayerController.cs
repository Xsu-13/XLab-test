
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

        private void Update()
        {
            Vector3 dir = Vector3.zero;
            dir = Input.acceleration;
            if(dir.sqrMagnitude >= 4f)
            {
                GameEvents.Shake();
                Debug.Log("Shaking");
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

