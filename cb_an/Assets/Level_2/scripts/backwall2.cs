using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backwall2 : MonoBehaviour
{
    private Camera mainCamera;
    public float cam_s = 3f;

    public string targetTag; // Tag of the target object

    private GameObject targetObject; // Reference to the target object

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        // Find the target object based on its tag
        targetObject = GameObject.FindGameObjectWithTag(targetTag);
    }
    // Update is called once per frame
    void Update()
    {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        Vector3 cameraPosition = mainCamera.transform.position;
        Vector3 tobe_reduced = new Vector3(c_w/2+1f,0,0);
        transform.position = cameraPosition - tobe_reduced;
        if (targetObject != null)
        {
            // Get the position of the target object
            Vector3 targetPosition = targetObject.transform.position;
            if (transform.position.x >= targetObject.transform.position.x)
        {
            Destroy(targetObject);
        }
        } 
    }
}



