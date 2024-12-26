using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    /*
     *  min : 0.3 ; max 1.2 , regular 1
     *  1. force to min value at start
     *  2. Lerp to max
     *  3. lerp to reg
     * 
     */

    public GameObject popObject;
    public float minValue;
    public float minHalfValue;
    public float maxHalfValue;
    public float maxValue;
    public float regValue;
    public float popSpeed;

    public bool testPop = false;

    private void Start()
    {
        popObject.transform.localScale = Vector3.one * minValue;
        minHalfValue = (minValue + regValue) / 1.5f;
        maxHalfValue = (maxValue + regValue) / 2f;
      

    }

    private void Update()
    {
        if (testPop)
        {
            testPop = false;
            StartCoroutine(PopObject());
        }
    }


    public IEnumerator PopObject()
    {
        print("Going max");
        yield return StartCoroutine(Move(minValue, maxValue, popSpeed * 0.75f ));
        print("Going Min half");

        yield return StartCoroutine(Move(maxValue, minHalfValue, popSpeed * 0.75f));
        print("Going maxhalf");
        yield return StartCoroutine(Move(minHalfValue, maxHalfValue, popSpeed * 0.25f));
        print("Going reg");
        yield return StartCoroutine(Move(maxHalfValue, regValue, popSpeed * 0.15f ));
    }

    public IEnumerator Move(float pointA, float pointB, float speed)
    {
        float counter = pointA;
        float timer = 0f;
        popObject.transform.localScale = Vector3.one * pointA;

        //0.3 < 1.1
        //x = counter, y = pointB
        // if (x-y <= 0.1f)
        while(Mathf.Abs(counter - pointB) >= 0.01f)
        {
            timer += Time.deltaTime * speed;
            counter = Mathf.Lerp(pointA, pointB, timer);
            popObject.transform.localScale = Vector3.one * counter;
            yield return null ;
        }
        popObject.transform.localScale = Vector3.one * pointB;
        yield return null;

    }

    /*
     *  MOVE(A,B)
     * 1. Given point A & B
     * 2. Until we reach point B
     * 3. Move towards b
     * 
     * 
     * 
     * Main()
     * 1. MOVE(min, max)
     * 2. MOVE(max, (min + reg)/2)
     * 3. MOVE((min + reg)/2, (max+reg)/2)
     * 4. MOVE((max+ reg)/2, reg)
     */
}
