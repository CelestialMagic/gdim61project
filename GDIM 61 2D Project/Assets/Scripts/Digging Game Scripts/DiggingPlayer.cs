using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DiggingPlayer : PlayerMovement
{
    [SerializeField]
    private InputAction verticalMovement;//A set of bindings for moving up and down.


    //Enables player movement
    protected override void OnEnable()
    {
        horizontalMovement.Enable();
        verticalMovement.Enable();
    }

    //Disables player movement
    protected override void OnDisable()
    {
        horizontalMovement.Disable();
        verticalMovement.Disable();
    }

    //Defines four-directional movement
    protected override void Movement()
    {
        float horizontalInput = horizontalMovement.ReadValue<float>();
        float verticalInput = verticalMovement.ReadValue<float>();

        applyToMove = new Vector2(horizontalInput * moveSpeed * Time.deltaTime, verticalInput * moveSpeed * Time.deltaTime);
        transform.Translate(applyToMove, Space.World);
    }
}
