using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Starts the game, and goes to Game Scene
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    //Will go back to Main Menu
    public void QuitGame()
    {
        Application.Quit();
    }
}
