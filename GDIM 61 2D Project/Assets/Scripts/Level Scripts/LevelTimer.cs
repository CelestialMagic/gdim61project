using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    //The global timer for the scene
    [SerializeField]
    private float levelTime;

    //The player in the scene
    [SerializeField]
    private PlayerMovement player;

    //The spawner in the scene
    [SerializeField]
    private FallingObstacleSpawner spawner;

    //Text display of level timer
    [SerializeField]
    private Text timeDisplay;

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    private void Countdown()
    {
        if ((levelTime - Time.deltaTime) <= 0)
        {
            player.StopMovement();
            spawner.ToggleActive(false);
        }
        else
        {
            levelTime -= Time.deltaTime;
            timeDisplay.text = $"Time: {(int) levelTime}";
        }
    }
}
