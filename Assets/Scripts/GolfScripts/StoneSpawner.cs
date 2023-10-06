using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    public List<GameObject> stones;
    public void Spawn()
    {
        Debug.Log("Hi");
        int index = Random.Range(0, stones.Count);
        Instantiate(stones[index], transform.position, Quaternion.identity);
    }
}
