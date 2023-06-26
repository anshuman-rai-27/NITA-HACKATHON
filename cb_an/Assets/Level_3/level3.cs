using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3 : MonoBehaviour
{
    private int value = 1;

    public GameObject[] fight ;
    public GameObject[] avoid ; 
    public GameObject[] normal ;
    public GameObject[] ui;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(value == 1)
        {
         normal[0].SetActive(true);
         //normal[0].transform.SetAsLastSibling();
        }
        else if(value == 2)
        {
          normal[1].SetActive(true);
        }
        else if(value == 3)
        {
          normal[2].SetActive(true);
        }
        /*else if(value == 20)
        {
          fight[0].SetActive(true);
        }
        else if(value == 21)
        {
          fight[1].SetActive(true);
        }
        */
        else if(value == 4)
        {
          avoid[0].SetActive(true);
        }
        else if(value == 5)
        {
          avoid[1].SetActive(true);
        }
        
    }

    public void fight_()
    {
        value = 20;
    }
    public void avoid_()
    {
        value = 10;
    }
    public void quit()
    {
        Application.Quit();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void next()
    {
      value++;
    }
    public void back()
    {
    gameObject.SetActive(false);
      value--;
    }
    
/*if (image != null)
        {
            image.gameObject.SetActive(false);
        }
        */
}
