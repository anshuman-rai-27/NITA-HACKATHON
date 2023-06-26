using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spa_wire : MonoBehaviour
{
    public GameObject[] wires;

    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        InvokeRepeating("spawnwires", 0,25f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = mainCamera.transform.position; 
    }
    
    private void spawnwires()
    {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        //Vector3 cam_height = new Vector3(2f * mainCamera.orthographicSize,0,0);
        
        Vector3 cam_width = new Vector3(c_w/2+10 ,0,0);
        Vector3 h_w = new Vector3(Random.Range(2f,3f),0f,5f);
        Vector3 cameraPosition = mainCamera.transform.position;

        // Randomly select an object from the array
        GameObject wire = wires[Random.Range(0, wires.Length)];
        
        // Randomly calculate a spawn position within the specified radius
        Vector3 spawnPosition = cameraPosition + cam_width + h_w; 

        // Spawn the object at the calculated position
        GameObject spawnedObject = Instantiate(wire, spawnPosition, Quaternion.identity);

        // Destroy the spawned object
        Destroy(spawnedObject, 30f);
    }
}
