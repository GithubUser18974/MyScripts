using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawns : MonoBehaviour {
    public float secondsBetweenSpawing = 0.5f;
    public GameObject[] spawnObjects;
    private float nextspawnTime;
    public Transform spawnTransform;
    private int counter=0;
	// Use this for initialization
	void Start () {
        nextspawnTime = Time.time + secondsBetweenSpawing;
	}
	
	// Update is called once per frame
	void Update () {
        
		if(Time.time >= nextspawnTime)
        {
            counter++;
            spawnNow();
            nextspawnTime = Time.time + secondsBetweenSpawing;
        }
	}
    void spawnNow()
    {
        if (counter >= 10 && counter <= 15)
        {
            if (secondsBetweenSpawing - 2.0f >= 3.0f)
            {
                secondsBetweenSpawing -= 2.0f;
            }

        }
        if (counter > 15)
        {
            secondsBetweenSpawing = 2f;
            

        }
        int objecttoSpawn = Random.Range(0, spawnObjects.Length);
        GameObject spawnobject = Instantiate(spawnObjects[objecttoSpawn], spawnTransform.position, spawnTransform.rotation) as GameObject;
        spawnobject.transform.parent = gameObject.transform;
    }
   
}
