using UnityEngine;

public class FlipPrefab : MonoBehaviour
{
    private void Start()
    {
        // Flip the prefab about the y-axis
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
