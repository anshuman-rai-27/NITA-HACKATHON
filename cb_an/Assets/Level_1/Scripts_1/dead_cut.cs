using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead_cut : MonoBehaviour
{
    public GameObject prefabToSpawn; // The prefab to spawn on collision
    //void Update(){
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has a specific tag
        if (collision.gameObject.CompareTag("Collidable"))
        {
            // Spawn the new prefab at the same position as the collided object
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

            // Destroy the collided object
            Destroy(collision.gameObject);
        }
    //}
    }
}

