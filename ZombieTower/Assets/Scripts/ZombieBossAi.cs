using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ZombieBossAi : MonoBehaviour {

    void Start()
    {
        
        GameObject home = GameObject.Find("Base");
        if (home)
            GetComponent<NavMeshAgent>().destination = home.transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider co)
    {

        if (co.name == "Base")
        {
            for(int i = 0; i < 3; i++)
            { 
                co.GetComponentInChildren<HealthScript>().decreaseBase();
            }
            Destroy(gameObject);
            


        }

    }
  
}
