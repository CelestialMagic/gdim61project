using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSite : MonoBehaviour
{

    private bool openSpot;

    [SerializeField]
    private GameObject site; 

    private void Start()
    {
        openSpot = true;
    }


    public bool GetOpenSpot()
    {
        return openSpot; 
    }

    //SetOpenSpot() allows other classes to alter the state of a dig site.
    public void SetOpenSpot(bool status)
    {
        openSpot = status; 
    }

    public Vector3 GetLocation()
    {
        return site.transform.position;
    }

}
