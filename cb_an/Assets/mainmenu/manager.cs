using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void level_2()
    {
        SceneManager.LoadScene(2);
    }
    public void level_3()
    {
        SceneManager.LoadScene(3);
    }
    public void quit()
    {
        Application.Quit();
    }
}
