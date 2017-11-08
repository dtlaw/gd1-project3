using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomObj : MonoBehaviour {
    public Transform playerCam;
    //private bool _held = false;
    private float _distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        _distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Cube")
        {
            Debug.Log("Boom");
        }
        /*
         * if self.name = door/lock {
         *      if c.name = bobbi pin:
         *         run animation
         *      else if c.name = key
         *         run door open animation
         *      else do nothing
         */
    }

    void OnMouseDown()
    {
        if (_distance < 1.0)
        {
            // If self.name = window, do window animation
            // if self.name = airvent, airvent falls off wall/alternate animation
            // else:
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = playerCam.position;
            this.transform.parent = GameObject.Find("FPSController").transform;
            this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;

            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            this.transform.SetPositionAndRotation(playerCam.position, playerCam.rotation);
            this.transform.Rotate(-34, 0, 180, Space.Self);

            GetComponent<Rigidbody>().freezeRotation = true;
            //_held = true;
        }
        else
        {
            Debug.Log("***" + _distance);
        }
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        GetComponent<Rigidbody>().freezeRotation = false;
        //_held = false;
    }

}
