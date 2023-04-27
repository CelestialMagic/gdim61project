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

    [SerializeField]
    private float resetTimer;

    [SerializeField]
    private float countdownTimer;

    [SerializeField]
    private float timeBuffer;

    private bool isActive;

    private void Start()
    {
        flip = 1;
        isActive = true;
    }

    // Update is called once per frame
    protected void Update()
    {
        if (isActive)
        {
            SpawnerMovement();
            CountdownSpawn();
        }
        

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

    //CountdownSpawn() 
    private void CountdownSpawn()
    {
        if(countdownTimer - Time.deltaTime <= 0)
        {
            countdownTimer = Random.Range(resetTimer - timeBuffer, resetTimer + timeBuffer);
            GameObject randomObject = fallingObjects[Random.Range(0, fallingObjects.Count)];
            randomObject.gameObject.transform.position = new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y);
            Instantiate(randomObject);
        }
        else
        {
            countdownTimer -= Time.deltaTime;

        }
    }
    public void ToggleActive(bool status)
    {
        isActive = status;
    }
}
