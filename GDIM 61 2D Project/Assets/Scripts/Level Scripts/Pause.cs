using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    private static bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            TogglePause();
        }
    }
    public void TogglePause()
    {
        if (isPaused)
        {
            isPaused = false;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }
}
