using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationVRTracking : MonoBehaviour
{
    public Transform vrOrientation;
    public Transform orientation;
    public Camera vrCamera;


    void Update()
    {
        if (vrCamera.enabled)
        {
            transform.rotation = Quaternion.Euler(0, vrOrientation.rotation.y, 0f);
            orientation.rotation = Quaternion.Euler(0, vrOrientation.rotation.y, 0f);
        }
    }
}
