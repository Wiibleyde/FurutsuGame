using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartandStop : MonoBehaviour
{
    public void StartGameButton()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(1);
    }

    public void QuitGameButton()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

