using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning_truck : MonoBehaviour
{
    public GameObject[] trucks;

    [SerializeField] CollisionManager sc;

    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        InvokeRepeating("SpawnTruck", 0,Random.Range(15f,60f));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = mainCamera.transform.position; 
    }
    
    private void SpawnTruck()
    {
        if(sc.score>=30)
        {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        //Vector3 cam_height = new Vector3(2f * mainCamera.orthographicSize,0,0);
        
        Vector3 cam_width = new Vector3(c_w/2+10 ,0,0);
        Vector3 h_w = new Vector3(Random.Range(2f,3f),0,5f);
        Vector3 cameraPosition = mainCamera.transform.position;

        // Randomly select an object from the array
        GameObject vehicle = trucks[Random.Range(0, trucks.Length)];
        
        // Randomly calculate a spawn position within the specified radius
        Vector3 spawnPosition = cameraPosition + cam_width + h_w; 

        // Spawn the object at the calculated position
        GameObject spawnedObject = Instantiate(vehicle, spawnPosition, Quaternion.identity);

        // Destroy the spawned object
        Destroy(spawnedObject, 10f);
        }
    }
}
