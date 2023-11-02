using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public TextAlignment highscoreText;

    int highscore = 0;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit ()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
