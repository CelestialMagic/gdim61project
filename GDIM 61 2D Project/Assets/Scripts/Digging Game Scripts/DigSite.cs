using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSite : MonoBehaviour
{

    private bool openSpot;//A boolean representing the state of dig site. 

    private GameObject currentTreasure; //The treasure attached to the spot

    [SerializeField]
    private GameObject site;//The gameobject representing the site

    private void Start()
    {
        openSpot = true;
    }

    //Returns the state of the boolean
    public bool GetOpenSpot()
    {
        return openSpot; 
    }

    //SetOpenSpot() allows other classes to alter the state of a dig site.
    public void SetOpenSpot(bool status)
    {
        openSpot = status; 
    }

    //Returns the location of the dig site
    public Vector3 GetLocation()
    {
        return site.transform.position;
    }

    //Sets the treasure object 
    public void SetTreasure(GameObject treasure)
    {
        currentTreasure = treasure; 
    }

    //Destroys the treasure 
    public void DestroyTreasure()
    {
        if(currentTreasure != null)
        {
            Destroy(currentTreasure);
            SetOpenSpot(true);
        }
        
    }
}
