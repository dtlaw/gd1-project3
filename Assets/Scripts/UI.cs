using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    //Find Canvases
    public GameObject mainCanvas;
    public GameObject twitterCanvas;
    public GameObject snapchatCanvas;
    public GameObject startCanvas;
    //Find Cameras
    public GameObject selfieCam;
    public GameObject mainCam;
    //Find other objects
    public UnityEngine.UI.Text timer;
    //Create timer
    private float timeLeft = 90.0f;
    //Check selfie cam
    private bool isMainCam;

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
        isMainCam = true;

    }
	
	// Update is called once per frame
	void Update () {
        //Change Screen Modes
		if (Input.GetKeyDown("t")) {
            OpenTwitter();
        }
        if (Input.GetKeyDown("c")) {
            OpenSnapchat();
        }
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
        //Make twitter canvas visible and other canvases invisible
        twitterCanvas.SetActive(true);
        snapchatCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to main camera
        mainCam.SetActive(true);
        selfieCam.SetActive(false);
        isMainCam = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void OpenSnapchat() {
        //Make snapchat canvas visible and other canvases invisible
        snapchatCanvas.SetActive(true);
        twitterCanvas.SetActive(false);
        mainCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to selfie camera
        mainCam.SetActive(false);
        selfieCam.SetActive(true);
        isMainCam = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OpenMain() {
        //Make snapchat canvas visible and other canvases invisible
        mainCanvas.SetActive(true);
        twitterCanvas.SetActive(false);
        snapchatCanvas.SetActive(false);
        startCanvas.SetActive(false);

        //Change to main camera
        mainCam.SetActive(true);
        selfieCam.SetActive(false);
        isMainCam = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void EndGame() {
        //You ran out of time 
    }
}
