using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour {

    //Define all objects
    public GameObject cup;
    public GameObject soap;
    public GameObject towel;
    public GameObject bath;
    public GameObject cabinet;
    public GameObject door;
    public GameObject floor;
    public GameObject sink;
    public GameObject key;
    public GameObject mirror;
    public GameObject paperTowel;
    public GameObject petals;
    public GameObject rose;
    public GameObject rug;
    public GameObject rugSmall;
    public GameObject showerHead;
    public GameObject shower;
    public GameObject table;
    public GameObject paper;
    public GameObject toilet;
    public GameObject rack;
    public GameObject shelf;
    public GameObject stack;
    public GameObject bin;
    public GameObject window;
    public GameObject vent;

    public GameObject player;
    public GameObject hand;

    public GameObject eventSys;
    public Text popUp;
    public int level;


    //Define Variables
    private float distance;
    private GameObject close;

    private bool move;

    // Use this for initialization
    void Start() {
        move = false;
        level = eventSys.GetComponent<EscapePlan>().level;
    }

    // Update is called once per frame
    void Update() {
        //level = eventSys.GetComponent<EscapePlan>().level;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green, 0, false);

        if (Input.GetMouseButtonDown(0)) { 
            print("click");
            CheckObject();
        }
        if (move == true && Input.GetKeyDown("return")) {
            level += 1;
            popUp.text = "";
        }

    }

   
    void CheckObject() {
        Ray photoLine = new Ray();
        RaycastHit hit = new RaycastHit();
        photoLine.origin = transform.position;
        photoLine.direction = Vector3.forward;


        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green, 0, false);
        //distance = Vector3.Distance(close.transform.position, hand.transform.position);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10f)) {
            //if (hit.transform != null && distance < 2f) {
            if (hit.transform != null) {
                print("click");
                if (hit.transform.tag == "Bath") {
                    print("HELL YEAH");
                    close = bath;
                //} else if (hit.transform.tag == "cup") {
                //    close = cup;
                    
                //} else if (hit.transform.tag == "soap") {
                //    close = soap;
                } else if (hit.transform.tag == "Towel") {
                    close = towel;
                    print("this is not a cup");
                //} else if (hit.transform.tag == "cabinet") {
                //    close = cabinet;
                } else if (hit.transform.tag == "Door") {
                    close = door;
                    print("door");
                    if (level == 0) {
                        print("door is locked");
                        popUp.text = "The Door is locked \n press enter";
                        move = true;
                    }
                //} else if (hit.transform.tag == "floor") {
                //    close = floor;
                //} else if (hit.transform.tag == "sink") {
                //    close = sink;
                } else if (hit.transform.tag == "key") {
                    close = key;
                } else if (hit.transform.tag == "petals") {
                    close = petals;
                } else if (hit.transform.tag == "shower") {
                    close = shower;
                } else if (hit.transform.tag == "table") {
                    close = table;
                } else if (hit.transform.tag == "Vent") {
                    close = vent;
                    print("vent");
                //} else if (hit.transform.tag == "toilet") {
                //    close = toilet;
                //} else if (hit.transform.tag == "rack") {
                //    close = rack;
                //} else if (hit.transform.tag == "shelf") {
                //    close = shelf;
                //} else if (hit.transform.tag == "plate") {
                //    close = plate;
                } else if (hit.transform.tag == "bin") {
                    close = bin;
                } else if (hit.transform.tag == "window") {
                    close = window;
                } 
            }
        }
    }
}



        
