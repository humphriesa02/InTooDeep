using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A human driven car in the car model.
/// 
/// Handles logic / data specific to human driven players.
/// </summary>
public class PlayerCharacter : Character
{
    /// <summary>
    /// "Brain" logic (gathering input) can be handled by this class.
    /// No other classes needed (for now).
    /// </summary>

    // PC gets input from the player of the game
    protected override void PollInput()
    {
        // Movement
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        // Interaction button pressed.


        // Menu button pressed
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            HUD.Instance.SetTaskBoardVisibility();
        }
    }
}
