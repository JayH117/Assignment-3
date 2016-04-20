using UnityEngine;
using System.Collections;


public class ZombieAI : MonoBehaviour {

	void Start(){
    GameObject home = GameObject.Find("Base");
    if (home)
        GetComponent<NavMeshAgent>().destination = home.transform.position;
    }
	
	// Update is called once per frame
	void OnTriggerEnter(Collider co)
    {
    
        if (co.name == "Base")
        {
            co.GetComponentInChildren<HealthScript>().decreaseBase();
            Destroy(gameObject);
            

        }
    }

}
