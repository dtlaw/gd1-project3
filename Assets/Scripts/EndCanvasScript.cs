using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvasScript : MonoBehaviour {

    public UnityEngine.UI.Text good;
    public UnityEngine.UI.Text bad;
    public UnityEngine.UI.Text scoring;
    private float _score = 9;

    // Use this for initialization
    void Start () {
        good.enabled = false;
        bad.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        Cursor.visible = false;
	}

    public void endText()
    {
        if (_score > 0)
        {
            good.enabled = true;
        }
        else
        {
            bad.enabled = true;
        }
        if (_score > 10)
        {
            scoring.text = "Romantic- You had a sauve setup, even under pressure. Marvelous work!";
        }
        else if (_score > 6)
        {
            scoring.text = "Average- It was a bit of a rush job, but it could have been worse.";
        }
        else
        {
            scoring.text = "Mediocre- Rather poor showing, try to be a bit more convincing next time.";
        }
    }
}
