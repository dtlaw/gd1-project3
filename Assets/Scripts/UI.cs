using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
=======
using UnityEngine.UI;
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96

public class UI : MonoBehaviour {

    //Find Canvases
    public GameObject mainCanvas;
    public GameObject twitterCanvas;
    public GameObject snapchatCanvas;
    public GameObject startCanvas;
<<<<<<< HEAD
    public GameObject selfieCam;
    public GameObject mainCam;
    public GameObject body;
=======
    //Find Cameras
    public GameObject selfieCam;
    public GameObject mainCam;
    //Find other objects
    public UnityEngine.UI.Text timer;
    //Create timer
    private float timeLeft = 90.0f;
    //Check selfie cam
    private bool isMainCam;
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96

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
<<<<<<< HEAD
=======
        isMainCam = true;
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96

    }
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
=======
        //Change Screen Modes
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96
		if (Input.GetKeyDown("t")) {
            OpenTwitter();
        }
        if (Input.GetKeyDown("c")) {
            OpenSnapchat();
        }
<<<<<<< HEAD
        if (Input.GetKeyDown("m")) {
            OpenMain();
        }
	}

    void OpenTwitter() {
        print ("twitter");
=======
        if (Input.GetKeyDown("return")) {
            OpenMain();
        }
        //Update Timer
        timeLeft -= Time.deltaTime;
        timer.text = ("Time left " + timeLeft.ToString("f0"));
        if (timeLeft <= 0) {
            EndGame();
        }
        //Take photo
        if (Input.GetKeyDown("space") && isMainCam == false) {
            //Application.CaptureScreenshot("Screenshot.png");
            //Application.CaptureScreenshot("Screenshot.png");
        }
        
	}

    void OpenTwitter() {
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96
        //Make twitter canvas visible and other canvases invisible
        twitterCanvas.SetActive(true);
        snapchatCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to main camera
        mainCam.SetActive(true);
        selfieCam.SetActive(false);
<<<<<<< HEAD
    }

    void OpenSnapchat() {
        print("snapchat");
=======
        isMainCam = true;
    }

    void OpenSnapchat() {
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96
        //Make snapchat canvas visible and other canvases invisible
        snapchatCanvas.SetActive(true);
        twitterCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to selfie camera
        mainCam.SetActive(false);
        selfieCam.SetActive(true);
<<<<<<< HEAD
=======
        isMainCam = false;
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96

        //if(body.Renderer.isVisible)
    }

    void OpenMain() {
<<<<<<< HEAD
        print("main");
=======
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96
        //Make snapchat canvas visible and other canvases invisible
        mainCanvas.SetActive(true);
        twitterCanvas.SetActive(false);
        snapchatCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to main camera
        mainCam.SetActive(true);
        selfieCam.SetActive(false);
<<<<<<< HEAD
=======
        isMainCam = true;
    }

    void EndGame() {
        //You ran out of time 
>>>>>>> 5f57ba6e02ef74af5ea70bfba09e5b42a533fd96
    }
}
