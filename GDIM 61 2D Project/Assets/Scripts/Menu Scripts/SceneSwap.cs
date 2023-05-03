using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{

    [SerializeField]
    private string gameMenu;

    [SerializeField]
    private string tennisGame;

    [SerializeField]
    private string diggingGame;

    [SerializeField]
    private string howToPlay;

    public void LoadGameMenu()
    {
      SceneManager.LoadScene(gameMenu);
    }
    public void LoadTennisGame()
    {
        SceneManager.LoadScene(tennisGame);
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene(howToPlay);
    }
}