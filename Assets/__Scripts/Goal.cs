using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Renderer))]
public class Goal : MonoBehaviour
{
    // Static field
    static public bool goalMet = false;

    void OnTriggerEnter(Collider other)
    {
        // When goal is hit, check for projectile
        Projectile proj = other.GetComponent<Projectile>();
        if(proj != null)
        {
            Goal.goalMet = true;
            // Set the color to higher opacity
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 0.75f;
            mat.color = c;
        }

    }
}
