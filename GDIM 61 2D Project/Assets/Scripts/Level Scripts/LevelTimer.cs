using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    //The global timer for the scene
    [SerializeField]
    protected float levelTime;

    //The player in the scene
    [SerializeField]
    protected PlayerMovement player;

    //The spawner in the scene
    [SerializeField]
    private Spawner spawner;

    //Text display of level timer
    [SerializeField]
    protected Text timeDisplay;

    // Update is called once per frame
    protected void Update()
    {
        Countdown();
    }

    protected virtual void Countdown()
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
