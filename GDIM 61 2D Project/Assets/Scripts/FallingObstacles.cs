using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallingObstacles : MonoBehaviour
{
    [SerializeField] //float representing max height of a floating obstacle
    private float rightBoundary;
    [SerializeField]
    private float leftBoundary;//float representing min height of a floating obstacle

    private bool hasHitWall;//bool used to determine if an obstacle is floating

    private int flip;//int used to determine negative or positive movement

    [SerializeField]
    private int fallSpeed; 

    // Update is called once per frame
    protected void Update()
    {

        //floating behavior:
        if (transform.position.x >= rightBoundary)
        {
            hasHitWall = false;
            FlipMovement();
            transform.Translate(flip * fallSpeed * Time.deltaTime, 0f, 0f);

        }
        else if (transform.position.x <= leftBoundary)
        {
            hasHitWall = true;
            FlipMovement();
            transform.Translate(flip * fallSpeed * Time.deltaTime, 0f, 0f);

        }
        else
        {
            transform.Translate(flip * fallSpeed * Time.deltaTime, 0f, 0f);

        }



    }

    //FlipMovement() determines when to move an obstacle up or down. 
    private void FlipMovement()
    {
        if (hasHitWall == true)
        {
            flip = 1;
        }
        else
        {
            flip = -1;
        }
    }
}

