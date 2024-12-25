using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    public GameObject twinkleObject;
    public float objectMaxScale;
    public float objectTwinkleSpeed;
    private float scaleCounter;

    private void Update()
    {
        TwinkleObject();
    }

    public void TwinkleObject()
    {

        scaleCounter = Mathf.PingPong(Time.time * objectTwinkleSpeed, objectMaxScale);
        twinkleObject.transform.localScale = Vector3.one * scaleCounter;
    }
}
