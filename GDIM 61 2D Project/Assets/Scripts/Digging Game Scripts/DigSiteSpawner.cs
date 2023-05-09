using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSiteSpawner : MonoBehaviour
{
    [SerializeField]
    private List<DigSite> digSites;//The available dig sites 

    [SerializeField]
    private List<GameObject> buriedTreasure;//A list of treasures to spawn


    [SerializeField]
    private float resetTimer;//A timer to reset

    [SerializeField]
    private float countdownTimer;//A timer to count down

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    //Spawns Spots for the player to dig at.
    //The spawner picks an open spot, picks a random treasure, spawns the treasure,
    //and closes the spot to prevent further spawning. 
    private void SpawnSpots()
    {

         DigSite randomSite = digSites[(int)(Random.Range(0, digSites.Count))];
         if (randomSite.GetOpenSpot() == true)
        {
            gameObject.transform.position = randomSite.GetLocation();
            GameObject randomTreasure = buriedTreasure[(int)(Random.Range(0, buriedTreasure.Count))];
            randomTreasure.transform.position = gameObject.transform.position;
            randomSite.SetTreasure(Instantiate(randomTreasure));
            randomSite.SetOpenSpot(false);

        }
            
        
    }

    //Countdown() is responsible for determining when to spawn next. 
    private void Countdown()
    {
        if (countdownTimer - Time.deltaTime <= 0)
        {
            SpawnSpots();
            countdownTimer = resetTimer;
        }
        else
        {
            countdownTimer -= Time.deltaTime;

        }
    }
}
