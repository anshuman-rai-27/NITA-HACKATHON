using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_g2 : MonoBehaviour
{
    // Start is called before the first frame update
    float ghost_0_sp = 1f;
    public Rigidbody2D rb ;
    
    public GameObject prefabToSpawn; // The prefab to spawn on collision

    // to check wether the player is dead or not
    private GameObject player;

    //Animation of ghost_0

    Animator animator ;
    
    // follow player

    public Transform player_t;
    public float mspeed_g2 = 5f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        player_t = GameObject.FindGameObjectWithTag("Collidable").transform;
        player = GameObject.FindGameObjectWithTag("Collidable");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has a specific tag and the prefab hasn't been spawned yet
        if (collision.gameObject.CompareTag("Collidable"))
        {
            // animation change to attack
            animator.SetBool("isnear_g2",true);
            InvokeRepeating("spawn_dead", 1f, 100000f);

            // Destroy the collided object
            Destroy(collision.gameObject,0.5f);

        }
    }
    private void spawn_dead(){
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            }

    // follow player

    void Update()
    {
        if(player != null){
        // Calculate the direction from the enemy to the player
        Vector3 direction = player_t.position - transform.position;
        direction.Normalize(); // Normalize the direction vector

        // Calculate the enemy's new position based on the direction and moveSpeed
        Vector3 newPosition = transform.position + direction * mspeed_g2 * Time.deltaTime;

        // Move the enemy to the new position
        transform.position = newPosition;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        rb.transform.Translate(Vector2.left *ghost_0_sp* Time.deltaTime);
    }
}
