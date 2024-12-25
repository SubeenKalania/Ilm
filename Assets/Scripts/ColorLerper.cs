using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorLerper : MonoBehaviour
{
    public Image gradientImage;
    public float lerpTime=0.1f;

    private float hue;
    private float saturation=0.45f;
    private float vibration=1f;


    private void Start()
    {
        gradientImage.color = Color.HSVToRGB(Random.Range(0f, 1f), saturation, vibration);
    }



    private void Update()
    {
        LerpColor();
    }




    public void LerpColor()
    {
        Color.RGBToHSV(gradientImage.color, out hue, out saturation, out vibration);
        hue = Mathf.PingPong(lerpTime * Time.time, 1.0f);

        gradientImage.color = Color.HSVToRGB(hue, saturation, vibration);
    }
    

}


/**
 * 1. We need to take the value in Hsv
 *      1.5 Update Hue value by lerpTime
 * 2. We need to convert the value in RGB
 * 3. 
 * 
 * /


/** 
 * 1. Go to the Image.color
 * 2. Connect the color to colorOne by x seconds
 * 3. Connect the color to colorTwo by x seconds
 * 
 */