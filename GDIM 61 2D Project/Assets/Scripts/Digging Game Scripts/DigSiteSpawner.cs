using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSiteSpawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> digSites;

    [SerializeField]
    private List<GameObject> buriedTreasure;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform randomSite = digSites[(int)(Random.Range(0, digSites.Count))];
        gameObject.transform.position = new Vector3 (randomSite.position.x, randomSite.position.y, 0);
        GameObject randomTreasure = buriedTreasure[(int)(Random.Range(0, buriedTreasure.Count))];
        randomTreasure.transform.position = gameObject.transform.position;
        Instantiate(randomTreasure);
    }
}
