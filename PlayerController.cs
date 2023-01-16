using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 gridSize = new Vector2(1, 1); // The size of each tile in the grid
    private Vector2 input; // The input for the player's movement
    private Vector3 targetPos; // The target position the player is moving towards
    public LayerMask blockingLayer; // The layer that represents objects that block movement
    //

    // Update is called once per frame
    void FixedUpdate()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        if (input.x != 0 || input.y != 0)
        {
            // Calculate the target position based on the input and grid size
            targetPos = new Vector3(transform.position.x + (input.x * gridSize.x), transform.position.y + (input.y * gridSize.y), transform.position.z);
            // Check if there is something blocking the target position
            if (!IsBlocked(targetPos))
            {
                // Move the player to the target position
                transform.position = targetPos;
            }
        }
    }

    // Check if the target position is blocked by an object on the blocking layer
    private bool IsBlocked(Vector3 targetPos)
    {
        // Create a circle at the target position with a radius of 0.1
        Collider2D hit = Physics2D.OverlapCircle(targetPos, 0.1f, blockingLayer);
        // If there is a collider at the target position, return true
        if (hit != null)
        {
            return true;
        }
        return false;
    }
}