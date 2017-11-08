using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public Transform playerCam;
    public Canvas end;
    public GameObject fps;

    [SerializeField]
    private float _distance;

    private void Start()
    {
        end.enabled = false;
    }

    void OnMouseDown()
    {
        _distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
        if (_distance > 8.0)
        {
            Debug.Log("The door won't open");
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
            end.enabled = true;
            end.GetComponent<EndCanvasScript>().endText();
        }
    }
}
