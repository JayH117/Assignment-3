using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;




public class HealthScript : MonoBehaviour {
    // The TextMesh Component
    TextMesh tm;

    
    // Use this for initialization
    void Start () {
        tm = GetComponent<TextMesh>();
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKey("escape"))
        {
            Application.Quit();

        }
    
        transform.forward = Camera.main.transform.forward;
    }
    
    public int current() {
    return tm.text.Length;
    }


    public void decreaseZom()
    {
        if (current() > 1)
        {
            tm.text = tm.text.Remove(tm.text.Length - 1);
        }
        else
        {
            //ZombieKill(ZomKill+=1);
            Destroy(transform.parent.gameObject);

        }
        
       /*
       if (ZomKill > 4)
        {
            ChangeToScene("Level2");

        }
        else if (ZomKill > 9)
        {
            ChangeToScene("Level3");
        }
        else if (ZomKill > 12)
        {
            ChangeToScene("Won");
        }
        */
    } 
    public void decreaseBase()
    {
        if (current() > 1)
        {
            tm.text = tm.text.Remove(tm.text.Length - 1);
        }
        else
        {
            Destroy(transform.parent.gameObject);
            ChangeToScene("Death");
        }
    }
    public void ChangeToScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }
}