using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI; //Static POI

    [Header("Dynamic")]
    public float camZ;

    void Awake()
    {
        camZ = this.transform.position.z;
    }

    void FixedUpdate ()
    {
        if (POI == null) return; // No POI, return

        // Get POI postion
        Vector3 destination = POI.transform.position;
        // Force destination.z to be camZ to keep camera far enough away
        destination.z = camZ;
        // Set the camera to the destination
        transform.position = destination;
    }
}
