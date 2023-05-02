using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TennisPlayerMovement : PlayerMovement
{
    //Defines movement for sidescrolling player
    protected override void Movement()
    {
        float horizontalInput = horizontalMovement.ReadValue<float>();
        applyToMove = new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0);
        transform.Translate(applyToMove, Space.World);
    }

}
