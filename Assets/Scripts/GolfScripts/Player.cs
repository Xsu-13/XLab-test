using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;
        bool isDown = false;
        public float range = 30f;
        public float speed = 500f;
        public float power = 200f;

        public Vector3 lastPosition;

        private void Update()
        {
            lastPosition = helper.position;
            //isDown = Input.GetMouseButton(0);

            Quaternion rot = stick.localRotation;
            Quaternion toRot = Quaternion.Euler(0, 0, isDown ? range : -range);

            rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);
            stick.localRotation = rot;
        }

        public void SetDown(bool value)
        {
            isDown = value;
        }

        public void onCollisionStick(Collider collider)
        {
            if (collider.TryGetComponent(out Rigidbody body))
            {
                var dir = (helper.position - lastPosition).normalized;
                body.AddForce(dir*power, ForceMode.Impulse);

                if(collider.TryGetComponent(out Stone stone))
                {
                    stone.isAfect = true;
                }
            }
        }
    }
}

