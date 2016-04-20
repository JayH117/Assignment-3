using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    
    public GameObject monsterPrefab;
    public int count = 0;
    public int zombies = 0;
    public float interval = 3;
    
    // Use this for initialization
    void Start() {
        InvokeRepeating("SpawnNext", interval, interval);
    }
    
    void SpawnNext() {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
        count++;
        zombies++;
         if(count > 3)
        {
            CancelInvoke("SpawnNext");
            if(zombies<=0)
            {

            }

        }
    }
    // need to add in largeZombie spawn

}