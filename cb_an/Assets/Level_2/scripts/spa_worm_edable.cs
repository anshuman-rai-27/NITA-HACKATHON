using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spa_worm_edable : MonoBehaviour
{
    public GameObject[] edibles;

    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        InvokeRepeating("Spa_edible", 0f,Random.Range(5f,11f));
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = mainCamera.transform.position; 
    }
    
    private void Spa_edible()
    {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        //Vector3 cam_height = new Vector3(2f * mainCamera.orthographicSize,0,0);
        
        Vector3 cam_width = new Vector3(c_w/2 ,0,0);
        Vector3 h_w = new Vector3(Random.Range(0,3f),Random.Range(-c_h/2+4,c_h/2-3),1f);

        Vector3 cameraPosition = mainCamera.transform.position;

        // Randomly select an object from the array
        GameObject edible = edibles[Random.Range(0, edibles.Length)];
        
        // Randomly calculate a spawn position within the specified radius
        Vector3 spawnPosition = cameraPosition + cam_width + h_w; 

        // Spawn the object at the calculated position
        GameObject spawnedObject = Instantiate(edible, spawnPosition, Quaternion.identity);

        // Destroy the spawned object
        Destroy(spawnedObject, 20f);
    }
}
