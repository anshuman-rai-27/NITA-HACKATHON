using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible_u : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array of object prefabs to spawn
    
    private Camera mainCamera; // main camera

    [SerializeField] ObjectCollector sc;
    
    private void Start()
    {
        //main camera
        mainCamera = Camera.main;
        
        InvokeRepeating("SpawnObject", 0, Random.Range(0.9f,4f));
        
    }

    private void Update()
    {
        // Get the current position of the camera
        Vector3 cameraPosition = mainCamera.transform.position;
        
    }

    private void SpawnObject()
    {
        if(sc.score >= 25)
        {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        //Vector3 cam_height = new Vector3(2f * mainCamera.orthographicSize,0,0);
        
        Vector3 cam_width = new Vector3(c_w/2 ,0,0);
        Vector3 h_w = new Vector3(Random.Range(0,3f),Random.Range(-c_h/2+2,c_h/2),1f);

        Vector3 cameraPosition = mainCamera.transform.position;
        // Randomly select an object from the array
        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

        // Randomly calculate a spawn position within the specified radius
        Vector3 spawnPosition = cameraPosition + cam_width + h_w; 

        // Spawn the object at the calculated position
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        // Destroy the spawned object
        Destroy(spawnedObject, 10f);
        }
    }
    

}


