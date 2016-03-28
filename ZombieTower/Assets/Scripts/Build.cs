using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {
    
    public GameObject tower;
    
    void OnMouseUpAsButton() {
    
    GameObject g = (GameObject)Instantiate(tower);
    g.transform.position = transform.position + Vector3.up;
    }
}