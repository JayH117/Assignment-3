using UnityEngine;
using System.Collections;

public class SpawnBullet : MonoBehaviour {
    public GameObject prefab;

    void Start() {
        InvokeRepeating("Spawn", 0, 10);
    }
    
    void Spawn() {
        Instantiate(prefab,
                    transform.position,
                    Quaternion.identity);
    }
}