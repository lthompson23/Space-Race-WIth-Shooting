using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void Play(string Game)
    {
        Debug.Log("Start");
        SceneManager.LoadScene(Game);
    }

    public void Quit()
    {
        //Quit the game
        Application.Quit();
        Debug.Log("Exit");
    }
}