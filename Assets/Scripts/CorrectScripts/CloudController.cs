using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorrectScene
{
    public class CloudController : MonoBehaviour
    {
        bool _moving = false;
        float moveSpeed = 8f;
        [SerializeField] Cloud cloud;
        [SerializeField] Transform[] endpoints;
        int targetIndex = -1;

        public void Action()
        {
            if (_moving)
            {
                return;
            }
            else
            {
                _moving = true;
                cloud.StopFX();

                targetIndex++;
                if (targetIndex == endpoints.Length)
                    targetIndex = 0;
            }
        }

        void Update()
        {
            if (!_moving)
                return;

            Transform target = endpoints[targetIndex];
            Vector3 targetPosition = new Vector3(target.position.x, cloud.transform.position.y, target.position.z);
            Vector3 offset = (targetPosition - cloud.transform.position).normalized * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(cloud.transform.position, targetPosition) < offset.magnitude)
            {
                cloud.transform.position = targetPosition;
                _moving = false;
                cloud.PlayFX();
            }
            else
            {
                cloud.transform.Translate(offset);
            }
        }
    }
}
