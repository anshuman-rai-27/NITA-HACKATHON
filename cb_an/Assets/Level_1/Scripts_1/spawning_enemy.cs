using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning_enemy : MonoBehaviour
{

    public GameObject[] enemy_s;

    [SerializeField] ObjectCollector sc;

    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        InvokeRepeating("Spawnenemy", 20f,Random.Range(0.9f,7f));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = mainCamera.transform.position;
    }
    private void Spawnenemy()
    {
        if(sc.score >=10){
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        //Vector3 cam_height = new Vector3(2f * mainCamera.orthographicSize,0,0);
        
        Vector3 cam_width = new Vector3(c_w/2 ,0,0);
        Vector3 h_w = new Vector3(Random.Range(0,3f),Random.Range(-c_h/2+4,c_h/2-3),1f);

        Vector3 cameraPosition = mainCamera.transform.position;
        // Randomly select an object from the array
        GameObject enemy_0 = enemy_s[0];
        
        // Randomly calculate a spawn position within the specified radius
        Vector3 spawnPosition = cameraPosition + cam_width + h_w; 

        // Spawn the object at the calculated position
        GameObject spawnedObject = Instantiate(enemy_0, spawnPosition, Quaternion.identity);

         // Destroy the spawned object
        Destroy(spawnedObject, 15f);
        }
    }
}
