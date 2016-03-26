using UnityEngine;
using System.Collections;

public class GuiSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    private void OnGUI()
    {
        GUI.Button(new Rect(15, 15, 100, 50), "Soldier");
    }
}
