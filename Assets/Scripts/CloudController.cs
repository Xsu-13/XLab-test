using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public Transform[] targets;
    [SerializeField] Cloud cloud;
    Transform cloudObj;
    float speed = 3f;
    int currentIndex = 0;
    bool moving = false;

    void Action()
    {
        if (moving)
            return;
        moving = true;
        currentIndex++;
        if(currentIndex >= targets.Length-1)
        {
            currentIndex = 0;
        }
    }
    private void Start()
    {
        cloudObj = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        Transform targetPos = targets[currentIndex].transform;
        cloudObj.transform.position = Vector3.Lerp(cloudObj.transform.position, targetPos.position, Time.deltaTime * speed);
    }

}
