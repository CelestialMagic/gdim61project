using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSiteSpawner : MonoBehaviour
{
    [SerializeField]
    private List<DigSite> digSites;

    [SerializeField]
    private List<GameObject> buriedTreasure;
   

    // Update is called once per frame
    void Update()
    {
        SpawnSpots();
    }


    private void SpawnSpots()
    {

            DigSite randomSite = digSites[(int)(Random.Range(0, digSites.Count))];
         if (randomSite.GetOpenSpot() == true)
        {
            gameObject.transform.position = randomSite.GetLocation();
            GameObject randomTreasure = buriedTreasure[(int)(Random.Range(0, buriedTreasure.Count))];
            randomTreasure.transform.position = gameObject.transform.position;
            Instantiate(randomTreasure);
            randomSite.SetOpenSpot(false);

        }
            
        
    }
}
