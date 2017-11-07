using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentScript : MonoBehaviour
{
    public Transform playerCam;

    [SerializeField]
    private float _distance;
    // EDIT X Y Z
    /// ///////////////
    private float _x = 0.0f;
    private float _y = 90.0f;
    private float _z = 0.0f;

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        // make sure distance is good enough that player can't reach
        ///////////////
        _distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
        if (_distance < 1.0)
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = playerCam.position;
            this.transform.parent = GameObject.Find("FPSController").transform;
            this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;

            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            this.transform.SetPositionAndRotation(playerCam.position, playerCam.rotation);
            this.transform.Rotate(_x, _y, _z, Space.Self);

            GetComponent<Rigidbody>().freezeRotation = true;
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
    }
}
