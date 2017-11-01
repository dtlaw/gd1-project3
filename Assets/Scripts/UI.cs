using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    //Find Canvases
    public GameObject mainCanvas;
    public GameObject twitterCanvas;
    public GameObject snapchatCanvas;
    public GameObject startCanvas;
    public GameObject selfieCam;
    public GameObject mainCam;
    public GameObject body;

    // Use this for initialization
    void Start () {
        //Make start canvas visible and other canvases invisible
        startCanvas.SetActive(true);
        snapchatCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        twitterCanvas.SetActive(false);

        //Set up Cameras
        mainCam.SetActive(true);
        selfieCam.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("t")) {
            OpenTwitter();
        }
        if (Input.GetKeyDown("c")) {
            OpenSnapchat();
        }
        if (Input.GetKeyDown("m")) {
            OpenMain();
        }
	}

    void OpenTwitter() {
        print ("twitter");
        //Make twitter canvas visible and other canvases invisible
        twitterCanvas.SetActive(true);
        snapchatCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to main camera
        mainCam.SetActive(true);
        selfieCam.SetActive(false);
    }

    void OpenSnapchat() {
        print("snapchat");
        //Make snapchat canvas visible and other canvases invisible
        snapchatCanvas.SetActive(true);
        twitterCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to selfie camera
        mainCam.SetActive(false);
        selfieCam.SetActive(true);

        //if(body.Renderer.isVisible)
    }

    void OpenMain() {
        print("main");
        //Make snapchat canvas visible and other canvases invisible
        mainCanvas.SetActive(true);
        twitterCanvas.SetActive(false);
        snapchatCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to main camera
        mainCam.SetActive(true);
        selfieCam.SetActive(false);
    }
}
