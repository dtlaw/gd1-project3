using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapePlan : MonoBehaviour {

    //Set public variables
    public int level;
    public UnityEngine.UI.Text list;

    //Set private variables
    private string listText;

	// Use this for initialization
	void Start () {
        level = 0;
	}
	
	// Update is called once per frame
	void Update () {
        switch (level) {
            case 0:
                print("Try to open the door");
                listText = ("How to escape! \n" + "◯Try the door \n");
                
                break;
            case 1:
                print("level 1");
                listText = ("How to escape! \n" + " ✔Try the door \n" + "◯Try the window \n");
                break;
            case 2:
                print("2");
                listText = ("How to escape! \n" + " ✔Try the window \n" + "◯Try the airvent \n");
                break;
            case 3:
                print("3");
                listText = ("How to escape! \n" + " ✔Try the airvent \n" + "◯Try looking the bin \n");
                break;
            case 4:
                print("4");
                listText = ("How to escape! \n" + " ✔Try looking in the bin \n" + "◯Try the towels \n");
                break;
            case 5:
                print("5");
                listText = ("How to escape! \n" + " ✔Try the towels \n" + "◯Open the door \n");
                break;
        }

        list.text = listText;
        CheckList();
    }

    public void CheckList () {

        if (level == 1) {

        } else if (level == 2) {

        }

    }

}
