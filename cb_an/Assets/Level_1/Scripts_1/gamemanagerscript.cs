using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanagerscript : MonoBehaviour
{
    private GameObject player;
    public GameObject gameOverUI ;
    // Start is called before the first frame update

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Collidable");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            gameOver();
            // Perform any desired actions when the GameObject is destroyed
        }
        
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quit()
    {
        Application.Quit();
    }

}
