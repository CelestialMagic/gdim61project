using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiggingLevelTimer : LevelTimer
{
    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    protected override void Countdown()
    {
        if ((levelTime - Time.deltaTime) <= 0)
        {
            player.StopMovement();
        }
        else
        {
            levelTime -= Time.deltaTime;
            timeDisplay.text = $"Time: {(int)levelTime}";
        }
    }
}
