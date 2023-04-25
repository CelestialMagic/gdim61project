using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private int levelScore;//The score of the level 

    [SerializeField]
    private Text scoreText;//The text to store the score

    // Start is called before the first frame update
    void Start()
    {
        levelScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {levelScore}";
    }

    //Increases the Score
    public void IncreaseScore()
    {
        levelScore++;
    }
    //Decreases the Score
    public void DecreaseScore()
    {
        levelScore--;
    }
}


