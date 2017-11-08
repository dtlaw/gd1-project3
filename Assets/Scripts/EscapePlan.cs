using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapePlan : MonoBehaviour {

    //Set public variables
    public int level;
    public UnityEngine.UI.Text list;
    public Text notification;

    //Set private variables
    private string listText;
    private string notificationText;

	// Use this for initialization
	void Start () {
        level = 0;
        notificationText = "";
	}
	
	// Update is called once per frame
	void Update () {
        switch (level) {
            case 0:
                listText = ("How to escape! \n" + "◯Try the Door \n");
                
                break;
            case 1:
                notificationText = ("New Text!");
                listText = ("How to escape! \n" + " ✔Try the Door \n" + "◯Respond to Text \n");
                break;
            case 2:
                notificationText = ("");
                listText = ("How to escape! \n" + " ✔Responded to Text \n" + "◯Try the Window \n");
                break;
            case 3:
                listText = ("How to escape! \n" + " ✔Try the Window \n" + "◯Take Selfie \n");
                break;
            case 4:
                listText = ("How to escape! \n" + " ✔Take Selfie \n" + "◯Try the Airvent \n");
                break;
            case 5:
                listText = ("How to escape! \n" + " ✔Try the Airvent \n" + "◯Respond to Text \n");
                break;
            case 6:
                listText = ("How to escape! \n" + " ✔Respond to Text \n" + "◯Try looking the bin \n");
                break;
            case 7:
                listText = ("How to escape! \n" + " ✔Try looking in the Bin \n" + "◯Take Selfie \n");
                break;
            case 8:
                listText = ("How to escape! \n" + " ✔ Take Selfie \n" + "◯Try the towels \n");
                break;
            case 9:
                listText = ("How to escape! \n" + " ✔Try the towels \n" + "◯Open the door \n");
                break;
            case 10:
                print("End of game");
                
                break;
        }

        list.text = listText;
        notification.text = notificationText;
        CheckList();
    }

    public void CheckList () {
        if (Input.GetKeyDown("space")) {
            level += 1;
        }
        //////////////

        if (level == 1) {

        } else if (level == 2) {

        }

    }

}
