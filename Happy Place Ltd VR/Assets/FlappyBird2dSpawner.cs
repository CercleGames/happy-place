using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird2dSpawner : MonoBehaviour {

    public GameObject[] obstacles;

     float timeBtwSpawn;
   public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    float originalStartTime;

	// Use this for initialization
	void Start () {
        originalStartTime = startTimeBtwSpawn;	
	}
	
	// Update is called once per frame
	void Update () {
		
        if(timeBtwSpawn <= 0)
        {
            //spawn
            Instantiate(obstacles[Random.Range(0, obstacles.Length)], transform.position, Quaternion.identity, transform);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn >= minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;

        }


	}

    public void StartOver()
    {
        startTimeBtwSpawn = originalStartTime;
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        timeBtwSpawn = 0;
        //take away points
    }
}
