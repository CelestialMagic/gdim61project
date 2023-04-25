using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacleSpawner : MonoBehaviour
{
    [SerializeField] //float representing right-most side 
    private float rightBoundary;
    [SerializeField]
    private float leftBoundary;//float representing left-most side 

    private bool hasHitWall;//bool used to determine if an obstacle is floating

    private int flip;//int used to determine negative or positive movement

    [SerializeField]
    private int moveSpeed;//a speed to move the spawner

    [SerializeField]
    private List<GameObject> fallingObjects;//A list of objects to spawn. 


    private void Start()
    {
        flip = 1; 
    }

    // Update is called once per frame
    protected void Update()
    {
        SpawnerMovement();


        

    }

    //FlipMovement() determines when to flip the direction of the spawner.
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

    private void SpawnerMovement()
    {
        //floating behavior:
        if (transform.position.x >= rightBoundary)
        {
            hasHitWall = false;
            FlipMovement();
            transform.Translate(flip * moveSpeed * Time.deltaTime, 0f, 0f);

        }
        else if (transform.position.x <= leftBoundary)
        {
            hasHitWall = true;
            FlipMovement();
            transform.Translate(flip * moveSpeed * Time.deltaTime, 0f, 0f);

        }
        else
        {
            transform.Translate(flip * moveSpeed * Time.deltaTime, 0f, 0f);

        }
    }
}
