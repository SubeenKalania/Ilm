using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{

    public GameObject rotateObject;
    public float rotateSpeed;

    public void Update()
    {
        RotateObject();
    }


    public void RotateObject()
    {
        rotateObject.transform.Rotate(new Vector3(0f, 0f, rotateSpeed * Time.deltaTime));

    }
}
/*
 * small dot-0.3,
 * med dot-0.4
 * large dot-0.8
 * star 2.3
 * 
 * 1. Decide what to create dot/star (more dots)
 * 2. random pixel, quantity any number 7-15
 * 3. pulse dots
 * 4. pulse and rotate the star
 * 
 * 
 */