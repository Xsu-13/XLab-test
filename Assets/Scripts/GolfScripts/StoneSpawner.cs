using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    public List<GameObject> stones;
    public GameObject Spawn()
    {
        int index = Random.Range(0, stones.Count);
        var stone = Instantiate(stones[index], transform.position, Quaternion.identity);
        return stone;
    }
}
