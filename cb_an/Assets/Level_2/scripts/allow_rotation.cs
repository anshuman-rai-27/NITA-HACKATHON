using UnityEngine;

public class allow_rotation : MonoBehaviour
{
    // Reference to the Rigidbody component
    private Rigidbody2D rb;

    // Rotation parameters
    public string targetTag;
    public float rotationSpeed = 100f;

    private void Start()
    {
        // Get the reference to the Rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision should trigger rotation based on the target tags
        
        
            if (collision.gameObject.CompareTag(targetTag))
            {
                // Get the contact point of the collision
                ContactPoint2D contact = collision.GetContact(0);

                // Calculate the rotation direction based on the contact normal
                Vector2 rotationDirection = Vector2.Perpendicular(contact.normal);

                // Apply rotation to the Rigidbody
                rb.angularVelocity = rotationSpeed * Mathf.Sign(Vector2.Dot(rb.velocity, rotationDirection));

            }
        
    }
}
