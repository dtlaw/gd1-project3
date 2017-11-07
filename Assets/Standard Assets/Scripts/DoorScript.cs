using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public Transform playerCam;

    [SerializeField]
    private float _distance;

    void OnMouseDown()
    {
        _distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
        if (_distance < 3.0)
        {
            Debug.Log("The door won't open");
        }
        else
        {
            Debug.Log("***" + _distance);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Pin")
        {
            Debug.Log("Pin tried, failed");
        }
        // throwing thing at door
        else if (c.gameObject.name == "???")
        {
            Debug.Log("BANG! but the door holds");
        }
        else if (c.gameObject.name == "KeyCard")
        {
            Debug.Log("Door opened!");
        }
    }
}
