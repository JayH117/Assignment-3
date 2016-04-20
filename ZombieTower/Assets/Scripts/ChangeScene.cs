using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
	}
    public void ChangeToScene(int sceneToChangeToNum)
    {
        Application.LoadLevel(sceneToChangeToNum);
    }
    public void Exit()
    {
        Application.Quit();

    }
}
