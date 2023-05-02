using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    protected InputAction horizontalMovement;//A set of bindings for moving left to right



    [SerializeField]
    protected Rigidbody2D rb;//The object's rigidbody, for movement force

    [SerializeField]
    protected int moveSpeed;//The speed at which to move an object.

    protected Vector2 applyToMove;//Stores movement

    [SerializeField]
    protected ScoreTracker scoreTracker; 

    //Enables player movement
    protected virtual void OnEnable()
    {
        horizontalMovement.Enable();
    }

    //Disables player movement
    protected virtual void OnDisable()
    {
        horizontalMovement.Disable();
    }

    //Update method runs every frame. Can be overridden by other
    //player movement children. 
    protected virtual void Update()
    {
        Movement();
    }

    //A template movement method for players 
    protected abstract void Movement();

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "TennisBall")
        {
            scoreTracker.IncreaseScore();
        }
        else if(collision.gameObject.tag == "Obstacle")
        {
            scoreTracker.DecreaseScore();
        }
    }
    //StopMovement() stops the player's movement
    public void StopMovement()
    {
        moveSpeed = 0;
    }


}
