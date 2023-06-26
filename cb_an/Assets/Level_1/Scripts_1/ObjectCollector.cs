using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollector : MonoBehaviour
{
    public float score = 0; // Player's score
    public float death_score = 0; // score leads to death

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has a specific tag (e.g., "Collectible")
        if ((collision.gameObject.CompareTag("Collectible")))
        {
            // Increment the score
            score++;

            // Destroy the collected object
            Destroy(collision.gameObject);

        }
        else if((collision.gameObject.CompareTag("untouchable")))
        {
            death_score++;
            Destroy(collision.gameObject);

        }
    }
}