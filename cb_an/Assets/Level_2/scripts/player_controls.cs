using UnityEngine;

public class player_controls : MonoBehaviour
{
    public float controlChangeTime = 0f; // Time after which controls will change

    private bool controlsChanged = false;

    [SerializeField] CollisionManager sc;

    public float speed;
    private float  Move;
    private Rigidbody2D rb;

    private void Start()
    {
        
    
        rb = gameObject.GetComponent<Rigidbody2D>() ;

        Invoke("ChangeControls", controlChangeTime);
    }

    void ChangeControls()
    {
        controlsChanged = true;
    }

    void Update()
    {

    

    
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Invert the inputs if controls have changed
        if(sc.score>=25)
    {
        if (controlsChanged)
        {
            horizontalInput *= -1f;
            verticalInput *= -1f;
        }
    }
        Vector3 movement = new Vector3(horizontalInput, verticalInput, verticalInput);
        rb.AddForce(movement * speed);
    
    }
}
