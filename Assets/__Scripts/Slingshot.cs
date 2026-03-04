using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    [SerializeField] private LineRenderer rubber;
    [SerializeField] private Transform firstPoint;
    [SerializeField] private Transform secondPoint;
    // fields set in the Unity Inspector Pane
    [Header("Inscribed")]
    public GameObject projectilePrefab;
    public float velocityMult = 10f;

    // fields set dynamically
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;


    void Start()
    {
        rubber.positionCount = 3;
        UpdateRubber(launchPos);
    }
    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }
    void OnMouseEnter()
    {
        // print("Slingshot: OneMouseEnter()");
        launchPoint.SetActive(true);
    }
    void OnMouseExit()
    {
        // print("Slingshot: OnMouseExit()");
        launchPoint.SetActive(false);
    }

    void OnMouseDown()
    {
        // The player has pressed the mouse button over slingshot
        aimingMode = true;
        // Instantiate projectile
        projectile = Instantiate( projectilePrefab ) as GameObject;
        // Start at launchpoint
        projectile.transform.position = launchPos;
        // Set it to IsKinematic 
        projectile.GetComponent<Rigidbody>().isKinematic = true;

        UpdateRubber(launchPos);
    }

    void Update()
    {
        // If slingshot is not in aimingMode, dont run
        if (!aimingMode) return;

        // Get current mouse position
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );

        // Find the delta from the launchPos
        Vector3 mouseDelta = mousePos3D -launchPos;
        // Limit mouseDelta to the radius of the Slingshot SphereCollider
        float maxMagnitude = this.GetComponent<SphereCollider>().radius;
        if (mouseDelta.magnitude > maxMagnitude)
        {
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }
        // Move the projectile to this new position
        Vector3 projPos = launchPos + mouseDelta;
        projectile.transform.position = projPos;
        UpdateRubber(projPos);

        if (Input.GetMouseButtonUp(0))
        {
            // Mouse is released
            aimingMode = false;
            Rigidbody projRB = projectile.GetComponent<Rigidbody>();
            projRB.isKinematic = false;
            projRB.collisionDetectionMode = CollisionDetectionMode.Continuous;
            projRB.velocity = -mouseDelta * velocityMult;
            FollowCam.POI = projectile; // Set the _MainCamera POI
            projectile = null;
            UpdateRubber(launchPos);
        }
    }

    void UpdateRubber(Vector3 centerPoint)
    {
        if (rubber == null) return;
        rubber.SetPosition(0, firstPoint.position);
        rubber.SetPosition(1, centerPoint);
        rubber.SetPosition(2, secondPoint.position);
    }
}
