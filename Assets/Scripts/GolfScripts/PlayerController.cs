
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
        void Update()
        {
            player.SetDown(Input.GetMouseButton(0));
        }
    }
}

