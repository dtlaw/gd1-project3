using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempCubeScript : MonoBehaviour {
    public Transform t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit h;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out h, 100.0f))
            {
                Debug.Log("Hello");
            }
        }
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Cube")
        {
            Debug.Log("Boom");
        }
    }

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = t.position;
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    void OnMouseUp()
    {
        GetComponent<Rigidbody>().useGravity = true;
        this.transform.parent = null;
    }

}
