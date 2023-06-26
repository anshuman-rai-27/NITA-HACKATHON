using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class untouchable_spawner : MonoBehaviour
{

    private Camera mainCamera;
    public GameObject enemy_1;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision involves the desired GameObjects
        if (collision.gameObject.CompareTag("untouchable"))
        {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        //Vector3 cam_height = new Vector3(2f * mainCamera.orthographicSize,0,0);
        
        Vector3 cam_width = new Vector3(c_w/2 ,0,0);
        Vector3 h_w = new Vector3(Random.Range(0,3f),Random.Range(-c_h/2+4,c_h/2),1f);

        Vector3 cameraPosition = mainCamera.transform.position;
       
        // Randomly calculate a spawn position within the specified radius
        Vector3 spawnPosition = cameraPosition + cam_width + h_w; 
        
        // Spawn the object at the calculated position
        Instantiate(enemy_1, spawnPosition, Quaternion.identity);
        
        }
        }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = mainCamera.transform.position;
    }
}
