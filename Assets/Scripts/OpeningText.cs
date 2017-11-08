using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningText : MonoBehaviour {

    public UnityEngine.UI.Text title;
    public UnityEngine.UI.Text credits;
    public UnityEngine.UI.Text enter;
    public UnityEngine.UI.Text next;
    public UnityEngine.UI.Text intro1;
    public UnityEngine.UI.Text intro2;

    // Use this for initialization
    void Start () {
        title.enabled = true;
        credits.enabled = true;
        enter.enabled = true;
        next.enabled = false;
        intro1.enabled = false;
        intro2.enabled = false;
	}

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) && title.enabled == true)
        {
            title.enabled = false;
            credits.enabled = false;
            enter.enabled = false;
            next.enabled = true;
            intro1.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Return) && intro1.enabled == true)
        {
            intro1.enabled = false;
            intro2.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Return) && intro2.enabled == true)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Setup Scene 2");
        }
    }
}
