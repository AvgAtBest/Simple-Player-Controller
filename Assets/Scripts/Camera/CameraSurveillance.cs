using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSurveillance : MonoBehaviour
{
    public Camera[] cameras;
    public KeyCode prevKey = KeyCode.Q;
    public KeyCode nextKey = KeyCode.E;
    private int camIndex;
    private int camMax;
    private Camera current;

	// Use this for initialization
	void Start ()
    {
        //Get all camera children and store into array
        cameras = GetComponentsInChildren<Camera>();
        //Last Index of array = Array.Length -1
        camMax = cameras.Length - 1;
        ActivateCamera(camIndex);
	}
	void ActivateCamera(int camIndex)
    {
        //loop through all surveillance cameras
        for(int i = 0; i < cameras.Length; i++)
        {
            Camera cam = cameras[i];
            //if current index matches the camIndex
            if(i == camIndex)
            {
                cam.gameObject.SetActive(true);
            }
            else//otherwise
            {
                //disable camera
                cam.gameObject.SetActive(false);
            }
        }
    }
	// Update is called once per frame
	void Update ()
    {
        //if next key is pressed
        if (Input.GetKeyDown(nextKey))
        {
            //increase index
            camIndex++;
            if(camIndex > camMax)
            {
                camIndex = 0;
            }
            ActivateCamera(camIndex);
        }
        //if next key is pressed
        if (Input.GetKeyDown(prevKey))
        {
            //increase index
            camIndex--;
            if (camIndex < 0)
            {
                camIndex = camMax;
            }
            ActivateCamera(camIndex);
        }
    }
}
