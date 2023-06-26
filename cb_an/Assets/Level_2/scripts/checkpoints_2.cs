using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoints_2 : MonoBehaviour
{
    private GameObject player;
    public GameObject checkpointui ;
    public GameObject previouslevelui ; // previous level
    public GameObject network_ui ;

    public float delay = 1f;  // Delay in seconds before pausing the game

    [SerializeField] CollisionManager sc;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Collidable");
    }

    // Update is called once per frame
    void Update()
    {
        if ((player == null))
        {
            gameOver();
            // Perform any desired actions when the GameObject is destroyed
        }
        else if ((sc.score >= 50))
        {
            win();
            // Perform any desired actions when the GameObject is destroyed
        }
        else if(sc.score>=25)
        {
            network();

        }
 
    }
    public void gameOver()
    {
        checkpointui.SetActive(true);
        PauseAfterDelay();

    }
    public void win()
    {
        previouslevelui.SetActive(true);
        PauseAfterDelay();
    }
    public void previouslevel()
    {
        SceneManager.LoadScene(1);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void checkpoint_1(){
        ToggleResume();
        player.SetActive(true);
        sc.score = 10 ;
    }
    public void TogglePause()
    {
            Time.timeScale = 0f;
    }
    public void ToggleResume()
    {  
            // Resume the game
            Time.timeScale = 1f;
    }
    public IEnumerator PauseAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        TogglePause();
    }
    public void network()
    {
        network_ui.SetActive(true);
    }
    public void nextlevel()
    {
         SceneManager.LoadScene(3);
    }

}
