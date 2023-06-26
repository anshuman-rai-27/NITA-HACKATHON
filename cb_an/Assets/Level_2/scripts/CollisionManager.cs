using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public int score = 0; // Player's score
    //public int death_score = 0; // score leads to death

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has a specific tag (e.g., "Collectible")
        if ((collision.gameObject.CompareTag("eat")))
        {
            // Increment the score
            score++;

            // Destroy the collected object
            Destroy(collision.gameObject);

            // Optionally, update UI or perform other actions based on the score
            Debug.Log("Score: " + score);
        }
        else if((collision.gameObject.CompareTag("worm")))
        {
            score+=5;
            Destroy(collision.gameObject);

            // Optionally, update UI or perform other actions based on the score
            Debug.Log("score" + score);

        }
        else if(collision.gameObject.CompareTag("rwire")||collision.gameObject.CompareTag("bwire")){
            Destroy(gameObject,0.2f);
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has a specific tag and the prefab hasn't been spawned yet
        if((collision.gameObject.CompareTag("cars"))||collision.gameObject.CompareTag("bikes")||collision.gameObject.CompareTag("trucks"))
        {
    
            Destroy(gameObject,1f);

            // Optionally, update UI or perform other actions based on the score
            Debug.Log("score" + score);

        }
    } 
}