using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static private FollowCam S;
    static public GameObject POI; //Static POI

    public enum eView{none,slingshot,castle,both};

    [Header("Inscribed")]
    public float easing = 0.10f;    // Changed from 0.05 to make more natural
    public Vector2 minXY = Vector2.zero; // Vector2.zero is [0,0]
    public GameObject viewBothGO;

    [Header("Dynamic")]
    public float camZ;
    public eView nextView = eView.slingshot;

    void Awake()
    {
        S = this;
        camZ = this.transform.position.z;
    }

    void FixedUpdate ()
    {
        // if (POI == null) return; // No POI, return

        // // Get POI postion
        // Vector3 destination = POI.transform.position;
        Vector3 destination = Vector3.zero;
        if (POI != null)
        {
            // If POI has a Rigidbody, check to see if it is sleeping (not moving)
            Rigidbody poiRigid = POI.GetComponent<Rigidbody>();
            if ((poiRigid != null) && poiRigid.IsSleeping())
            {
                POI = null; // Set the POI to null   
            }
        }
        if (POI != null)
        {
            destination = POI.transform.position;
        }

        // Limit the X & Y to minimum values
        destination.x = Mathf.Max(minXY.x, destination.x);
        destination.y = Mathf.Max(minXY.y, destination.y);
        // Interpolate from the current camera position toward the destination
        destination = Vector3.Lerp(transform.position, destination, easing);
        // Force destination.z to be camZ to keep camera far enough away
        destination.z = camZ;
        // Set the camera to the destination
        transform.position = destination;
        // Set the orthographicSize of the camera to keep Ground in view
        Camera.main.orthographicSize = destination.y + 10;
    }

    public void SwitchView(eView newView)
    {
        if (newView == eView.none)
        {
            newView = nextView;
        }
        switch (newView)
        {
        case eView.slingshot:
            POI = null;
            nextView = eView.castle;
            break;
        case eView.castle:
            POI = MissionDemolition.GET_CASTLE();
            nextView = eView.both;
            break;
        case eView.both:
            POI = viewBothGO;
            nextView = eView.slingshot;
            break;
        }
    }

    public void SwitchView()
    {
        SwitchView(eView.none);
    }

    static public void SWITCH_VIEW(eView newView)
    {
        S.SwitchView(newView);
    }
}
