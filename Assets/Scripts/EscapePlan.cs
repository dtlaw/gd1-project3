using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePlan : MonoBehaviour {

    public int level; 

	// Use this for initialization
	void Start () {
        level = 0;
	}
	
	// Update is called once per frame
	void Update () {
        switch (level) {
            case 0:
                print("intro");
                break;
            case 1:
                print("level 1");
                break;
            case 2:
                print("2");
                break;
            case 3:
                print("3");
                break;
            case 4:
                print("4");
                break;
            case 5:
                print("5");
                break;
        }

    }

}
