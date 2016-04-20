using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {
    //totrack zom kills
    public int ZomKill = 0;
    // Update is called once per frame
    public void ChangeToScene (string sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
	}
   
    public void Exit()
    {
        Application.Quit();

    }
}
