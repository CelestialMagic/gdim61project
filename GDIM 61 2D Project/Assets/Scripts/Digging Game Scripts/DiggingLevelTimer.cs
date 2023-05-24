using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiggingLevelTimer : LevelTimer
{
    protected override void Countdown()
    {
        if ((levelTime - Time.deltaTime) <= 0)
        {
            player.StopMovement();
            endMenu.SetActive(true);
        }
        else
        {
            levelTime -= Time.deltaTime;
            timeDisplay.text = $"Time: {(int)levelTime}";
        }
    }
}
