using UnityEngine;

public class speed_Vehicles : MonoBehaviour
{
    public float speed; // Speed of the object

    private Rigidbody2D rb; // Reference to the Rigidbody component

    void Start()
    {
        // Get the reference to the Rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // Apply leftward velocity to the object continuously
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
}
