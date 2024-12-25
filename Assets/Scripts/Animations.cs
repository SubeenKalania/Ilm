using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    public float rotationSpeed = 100f;
    public Vector3 maxScale = new Vector3(2f, 2f, 1f); // Maximum scale
    public Vector3 minScale = new Vector3(1f, 1f, 1f); // Minimum scale
    public float scaleSpeed = 2f; // Speed of scaling

    private bool scalingUp = true;

    public void ScaleAnimation()
    {
        if (scalingUp)
        {
            // Scale up
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, scaleSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.localScale, maxScale) < 0.01f) // Close enough to max scale
            {
                scalingUp = false; // Switch to scaling down
            }
        }
        else
        {
            // Scale down
            transform.localScale = Vector3.Lerp(transform.localScale, minScale, scaleSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.localScale, minScale) < 0.01f) // Close enough to min scale
            {
                scalingUp = true; // Switch to scaling up
            }
        }
    }

    public void RotateAnimation()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

}



