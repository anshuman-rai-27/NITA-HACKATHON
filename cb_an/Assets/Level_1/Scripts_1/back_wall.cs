using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_wall : MonoBehaviour
{
    private Camera mainCamera;
    public float cam_s = 3f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        float c_h = 2f * mainCamera.orthographicSize;
        float c_w = c_h * mainCamera.aspect;
        Vector3 cameraPosition = mainCamera.transform.position;
        Vector3 tobe_reduced = new Vector3(c_w/2+1f,0,0);
        transform.position = cameraPosition - tobe_reduced;
    }
}
