using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class CharacterAnimation : MonoBehaviour
    {
        [SerializeField] Animator animator;

        private void OnEnable()
        {
            GameEvents.onShaking += StartAnimation;
        }

        private void OnDisable()
        {
            GameEvents.onShaking -= StartAnimation;
        }

        private void StartAnimation()
        {
            animator.SetBool("shaking", true);
            Invoke("DisableAnimation", 0.2f);
        }

        void DisableAnimation()
        {
            animator.SetBool("shaking", false);
        }
    }
}
