using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed;
    private float  Move;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    
        rb = gameObject.GetComponent<Rigidbody2D>() ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1

       
       Vector3 movement = new Vector3(xMove, zMove, zMove);
       rb.AddForce(movement * speed);

    }
}
