using UnityEngine;
using System.Collections;

public class ZombieAI : MonoBehaviour {

	void Start(){
    GameObject zombie = GameObject.Find("Zombie");
    if (zombie)
        GetComponent<NavMeshAgent>().destination = zombie.transform.position;
    }
	
	// Update is called once per frame
	void OnTriggerEnter(Collider co) {
    
    if (co.name == "Zombie") {
        co.GetComponentInChildren<HealthScript>().decrease();
        Destroy(gameObject);
        }
    }
}
