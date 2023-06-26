using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost0_controller : MonoBehaviour
{
    // Start is called before the first frame update
    float ghost_0_sp = 1f;

    public Rigidbody2D rb ;

    public GameObject prefabToSpawn; // The prefab to spawn on collision
    
    //Animation of ghost_0

    Animator animator ;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has a specific tag and the prefab hasn't been spawned yet
        if (collision.gameObject.CompareTag("Collidable"))
        {
            // animation change to attack

            animator.SetBool("isnear",true);

            InvokeRepeating("spawn_dead", 1f, 100000f);     

            // Destroy the collided object
            Destroy(collision.gameObject,0.5f);
        }
    }
    private void spawn_dead(){
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            }

    // Update is called once per frame
    void FixedUpdate()
    {       
        rb.transform.Translate(Vector2.left *ghost_0_sp* Time.deltaTime);       
    }
}
