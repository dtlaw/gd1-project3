using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowelScript : MonoBehaviour
{
    public Transform playerCam;
    public GameObject key;

    [SerializeField]
    private float _distance;
    private bool _held = false;
    private bool _keyDropped = false;
    private float _x = 0.0f;
    private float _y = 90.0f;
    private float _z = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (_held && !_keyDropped)
        {
            // drop key animations
            _keyDropped = true;
            key.SetActive(true);
        }
    }

    void OnMouseDown()
    {
        _distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
        if (_distance < 2.5)
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = playerCam.position;
            this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;

            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            this.transform.SetPositionAndRotation(playerCam.position, playerCam.rotation);
            this.transform.Rotate(_x, _y, _z, Space.Self);

            GetComponent<Rigidbody>().freezeRotation = true;
            _held = true;
        }
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        GetComponent<Rigidbody>().freezeRotation = false;
        _held = false;
    }
}
