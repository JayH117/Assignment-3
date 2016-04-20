using UnityEngine;
using System.Collections;

public class Spawn2 : MonoBehaviour {


    public GameObject monsterPrefab;
    public int zombies = 0;
    public float interval = 3;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnBoss",interval,interval);
    }

    void SpawnBoss()
    {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
        zombies++;
        if (zombies > 0)
        {
            CancelInvoke("SpawnBoss");
        }
    }
   

}
