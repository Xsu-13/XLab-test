using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Golf
{
    public class CameraShaking : MonoBehaviour
    {
        [SerializeField] Vector3 _positionStrength;
        [SerializeField] Vector3 _rotationStrength;

        private void OnEnable()
        {
            GameEvents.onExplosion += Shake;
        }

        private void OnDisable()
        {
            GameEvents.onExplosion -= Shake;
        }

        void Shake()
        {
            transform.DOComplete();
            transform.DOShakePosition(0.5f, _positionStrength);
            transform.DOShakeRotation(0.5f, _rotationStrength);
            Handheld.Vibrate();
        }
    }
}
