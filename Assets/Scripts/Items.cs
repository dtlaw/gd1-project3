using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public GameObject player;

    //Define Variables
    private float distance;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        CheckObject();

    }

    void OnMouseDown() {
        //distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
        if (distance < 1.0) {
            GetComponent<Rigidbody>().useGravity = false;
            // this.transform.position = playerCam.position;
            //this.transform.parent = GameObject.Find("FPSController").transform;
            this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;

            // GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            // this.transform.SetPositionAndRotation(playerCam.position, playerCam.rotation);
            //this.transform.Rotate(_x, _y, _z, Space.Self);

            GetComponent<Rigidbody>().freezeRotation = true;
            //_held = true;
        } else {
            //Debug.Log("***" + _distance);
        }
    }

    void OnMouseUp() {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        GetComponent<Rigidbody>().freezeRotation = false;
        //_held = false;
    }

    void CheckObject() {
        Ray photoLine = new Ray();
        RaycastHit hit = new RaycastHit();
        photoLine.origin = transform.position;
        photoLine.direction = Vector3.forward;


        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green, 0, false);
        //if (Physics.Raycast(transform.position, forward, 100) && inPhoto.transform.tag == "Furniture" ) {
        //if (Physics.Raycast(photoLine, out inPhoto) && inPhoto.transform.tag == "Furniture") { 
        print("green");
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10f)) {
            print("raycast green");
            if (hit.transform != null) {
                print("object -- " + hit);
                if (hit.transform.tag == "Bath") {
                    print("HELL YEAH");
                }
            }
        }
    }

}

        
