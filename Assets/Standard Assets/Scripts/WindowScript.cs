using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    public Transform playerCam;

    [SerializeField]
    private float _distance;

    void OnMouseDown()
    {
        _distance = Vector3.Distance(playerCam.transform.position, this.transform.position);
        if (_distance < 1.3)
        {
            // window animations
            // may have to limit to just one time
            Debug.Log("The window doesn't open");
        }
        else
        {
            Debug.Log("***" + _distance);
        }
    }
}
