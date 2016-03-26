using UnityEngine;
using System.Collections;

public class SpawnTurret : MonoBehaviour {
    public SpawnTurret prefab;

    void Start() {
        InvokeRepeating("Spawn", 0, 10);
    }
    
    void Spawn() {
        Instantiate(prefab,
                    transform.position,
                    Quaternion.identity);
    }
}
