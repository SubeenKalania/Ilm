using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /*
     * 0. if count is 1 then no division by quantity
     * 1. Spawn x amount of objects
     * 2. loop through every object and place them randomly
     * 
     */

    public List<GameObject> spawnProps = new List<GameObject>();
    public int maxQuantity;
    private int spawnQuantity;
    

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        // deciding quantity to spawn
        if (spawnProps.Count > 1)
        {
            spawnQuantity = maxQuantity / spawnProps.Count;
        }
        else
        {
            spawnQuantity = maxQuantity;
        }

        // Spawning as per the quantity
        for(int i=0; i < spawnProps.Count; i++)
        {
            for (int j=0; j < spawnQuantity; j++)
            {
                //spawn and randomly place
                Instantiate(spawnProps[i], new Vector3(Random.Range(0,Screen.width), Random.Range(0,Screen.height), 0), Quaternion.identity, gameObject.transform);

            }
        }
    }
}
