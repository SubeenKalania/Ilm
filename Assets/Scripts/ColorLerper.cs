using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorLerper : MonoBehaviour
{
    public Image gradientImage;
    public float lerpTime=0.1f;
    public bool isFlipped;
    public float offset = 0.5f;

    private float hue;
  
    public float saturation;
    public float vibration = 1f;


 

        


    private void Update()
    {
        LerpColor();
    }




    public void LerpColor()
    {
        
        if (isFlipped == true)
        {
            Color.RGBToHSV(gradientImage.color, out hue, out saturation, out vibration);
            hue =Mathf.Abs(Mathf.PingPong(lerpTime * Time.time + offset, 1.0f) - 1f);

        }
        else
        {
            hue = Mathf.PingPong(lerpTime * Time.time, 1.0f);

        }
       

        gradientImage.color = Color.HSVToRGB(hue, saturation, vibration);
    }


}



 