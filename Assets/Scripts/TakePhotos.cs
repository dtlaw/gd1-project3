using UnityEngine;
using System.Collections;
//using UnityEditor.

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
        int score;
        score = 10;
        //Camera.OnWillRenderObject()
        //selfieCam.camera.on
        //bath.renderer.
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, forward, 10)) {
            print ("visible");
        }
        return score;
    }

    void LateUpdate() {
        takeHiResShot |= Input.GetKeyDown("k");

        if (takeHiResShot) {
            RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
            //camera.targetTexture = rt;
            selfieCam.targetTexture = rt;
            Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            //camera.Render();
            selfieCam.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            //camera.targetTexture = null;
            selfieCam.targetTexture = null;
            RenderTexture.active = null; // JC: added to avoid errors
            Destroy(rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName(resWidth, resHeight);
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            takeHiResShot = false;
        }
    }
}