using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorrectScene
{
    public class Cloud : MonoBehaviour
    {
        [SerializeField] ParticleSystem _particleSystem;

        private void Start()
        {
            _particleSystem.Stop();
        }

        public void PlayFX()
        {
            _particleSystem.Play();
        }

        public void StopFX()
        {
            _particleSystem.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }
}

