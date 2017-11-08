using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Adapted from https://answers.unity.com/questions/22954/how-to-save-a-picture-take-screenshot-from-a-camer.html
// Originally created by jashan

public class TakePhotos:MonoBehaviour {
    public int resWidth = 2550;
    public int resHeight = 3300;
    public Camera selfieCam;
    public GameObject bath;

    private bool takeHiResShot = false;

    public static string ScreenShotName(int width, int height) {
        return string.Format("{0}/screenshots/screen_{1}x{2}_{3}.png",
                             Application.dataPath,
                             width, height,
                             System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }

    public void TakeHiResShot() {
        takeHiResShot = true;
    }

    public int SelfieScore() {
        int score = 0;

        // Get gameobjects that have scores components
        ObjectScore[] temp = GameObject.FindObjectsOfType< ObjectScore >();
        var scoredObjects = new GameObject[ temp.Length ];
        for ( int i = 0; i < temp.Length; ++i ) {
            scoredObjects[ i ] = temp[ i ].gameObject;
        }
        var visibleObjects = new List< GameObject >();
        Vector3 camPos = selfieCam.transform.position;
        foreach ( GameObject g in scoredObjects ) {
            Vector3 pos = selfieCam.WorldToScreenPoint( g.transform.position );
            if ( pos.z > 0 && pos.x > 0 && pos.x < selfieCam.pixelWidth && pos.y > 0 && pos.y < selfieCam.pixelHeight ) {
                RaycastHit hit;
                Physics.Raycast( camPos, g.transform.position - camPos, out hit );
                if ( hit.collider && hit.collider.gameObject == g ) {
                    visibleObjects.Add( g );
                    print( "Visible" );
                }
            }
        }

        return score;
    }

    void LateUpdate() {
        takeHiResShot |= Input.GetKeyDown("k");
        //Get Score of photo
        SelfieScore();

        if (takeHiResShot) {
            RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
            selfieCam.targetTexture = rt;
            Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            selfieCam.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            selfieCam.targetTexture = null;
            RenderTexture.active = null; // JC: added to avoid errors
            Destroy(rt);
            // byte[] bytes = screenShot.EncodeToPNG();
            // string filename = ScreenShotName(resWidth, resHeight);
            // System.IO.File.WriteAllBytes(filename, bytes);
            // Debug.Log(string.Format("Took screenshot to: {0}", filename));
            takeHiResShot = false;

            SelfieScore();
        }
    }
}