using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public Transform AsteroidPrefab;

    

    public float speed;
    
    //Defining an array to hold the possible spawn points
    public GameObject[] spawnPoints = new GameObject[6];
    //The seconds between the instantiation of each ting
    public float spawnRate = 1.0f;
    //A counter used to keep track of the time between ring instantiations
    private float spawnCounter = 0.0f;

    private void Start()
    {
        //We start with the counter equal to the rate so rings start spawning
        //right away
        spawnCounter = spawnRate;
    }

    
    
    // Update is called once per frame
    void Update()
    {
        

        
        //The delta time is added to the counter to keep track of time
        spawnCounter += Time.deltaTime;

        //If the counter has surpassed the rate, we're ready to spawn something
        if (spawnCounter > spawnRate)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            //Spawn something
            //Debug.Log("Spawning ring at " + spawnPoints[randomIndex].name);

            //Spawn the ring prefab at the position of the randomly selected 
            //spawn point, with the rotation of said spawn point
            Instantiate(AsteroidPrefab, spawnPoints[randomIndex].transform.position,
                spawnPoints[randomIndex].transform.rotation);
            
            
            //The counter is reset

            spawnCounter = 0.0f;
        }
    }
}