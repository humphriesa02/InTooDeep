using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
	CharacterStateMachine csm;
	float moveSpeed;
	public MoveState(CharacterStateMachine stateMachine)
	{
		csm = stateMachine;
	}
	public void OnBegin(StateMachine stateMachine){}

	public void OnUpdate()
	{
		moveSpeed = csm.character.isRunning ? csm.character.runSpeed : csm.character.walkSpeed;
		CheckForInput();
	}

	public void OnPhysicsUpdate()
	{
		// Move based on input from Character
		csm.character.rb.MovePosition(csm.character.transform.position + new Vector3(csm.character.moveInput.x, 0, csm.character.moveInput.y) * Time.fixedDeltaTime * moveSpeed);
	}

	public void OnExit()
	{
		// Set velocity to 0
	}

	public void CheckForInput()
	{
		// Transition to idle
		if (csm.character.moveInput.magnitude < 0.1)
		{
			csm.ChangeState(csm.idleState);
		}

		// Jump Button pressed

		// Interact Button Pressed
	}
}
