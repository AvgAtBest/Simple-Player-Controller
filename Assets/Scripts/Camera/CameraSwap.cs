using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Transform[] lookObjects; //array of objects to look at
    public bool smooth = true; //Is smooth enabled?
    public float damping = 6; //smoothness value of camera
    [Header("GUI")]
    public float scrW;
    public float scrH;

    private int camIndex;//Index into array of lookObjects
    private int camMax; //stores total amount of lookObjects
    private Transform target; //current target look object

	void Start ()
    {
        //Last index of array
        camMax = lookObjects.Length - 1;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        //Get current object to look at
        target = lookObjects[camIndex];
        //if target is not null
        if (target)
        {
            //if smooth is enabled
            if (smooth)
            {
                //calculate direction to look at rotation
                Vector3 lookDirection = target.position - transform.position;
                Quaternion rotation = Quaternion.LookRotation(lookDirection);
                //look at and dampen rotation
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            }
            else
            {
                //looks at target without smooth and dampen
                transform.LookAt(target);
            }
        }
        else
        {
            //keep swapping cameras until valid target is found
            CamSwap();
        }
    }
    void CamSwap()
    {
        camIndex++;
        //if Index is greater than our max array size
        if(camIndex > camMax)
        {
            //Reset camIndex back to zero
            camIndex = 0;
        }
    }
    private void OnGUI()
    {
        if (scrW != Screen.width / 16 || scrH != Screen.height / 9)
        {
            scrW = Screen.width / 16;
            scrH = Screen.height / 9;
        }
        if(GUI.Button(new Rect(0.5f*scrW,0.25f*scrH,1.5f*scrW,0.75f*scrH), "Swap"))
        {
            CamSwap();
        }
    }
}
