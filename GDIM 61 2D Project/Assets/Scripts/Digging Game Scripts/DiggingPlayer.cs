using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DiggingPlayer : PlayerMovement
{
    [SerializeField]
    private InputAction verticalMovement;//A set of bindings for moving up and down.

    private DigSite currentDigSite;

    private bool inRange;

    private int testScore;

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
        if (Input.GetKeyDown(KeyCode.Space) && (inRange)) 
        {
            scoreTracker.IncreaseScore();
            currentDigSite.DestroyTreasure();
        }
    }

    //OnTriggerEnter2D() detects if player enters a dig site
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Dig Site")
        {
            inRange = true;
            currentDigSite = collision.gameObject.GetComponent<DigSite>();

        }
    }

    //OnTriggerExit() determines if player left the spot 
    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
    }
}
