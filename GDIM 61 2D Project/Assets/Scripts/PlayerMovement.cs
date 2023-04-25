using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    protected InputAction horizontalMovement;//A set of bindings for moving left to right

    [SerializeField]
    protected Rigidbody2D rb;//The object's rigidbody, for movement force

    [SerializeField]
    protected int moveSpeed;//The speed at which to move an object.

    protected Vector2 applyToMove;//Stores movement

    //Enables player movement
    protected void OnEnable()
    {
        horizontalMovement.Enable();
    }

    //Disables player movement
    protected void OnDisable()
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
    protected virtual void Movement()
    {
        float horizontalInput = horizontalMovement.ReadValue<float>();
        applyToMove = new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0);
        transform.Translate(applyToMove, Space.World);

    }






}
