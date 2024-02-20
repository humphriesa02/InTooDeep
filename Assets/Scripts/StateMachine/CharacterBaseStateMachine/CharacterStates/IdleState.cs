using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
	CharacterStateMachine csm;
	public IdleState(CharacterStateMachine stateMachine)
	{
		csm = stateMachine;
	}
	public void OnBegin(StateMachine stateMachine)
	{
		csm.character.rb.velocity = Vector3.zero;
	}

	public void OnUpdate()
	{
		CheckForInput();
	}

	public void OnPhysicsUpdate(){}

	public void OnExit()
	{

	}

	public void CheckForInput()
	{
		// Transition to idle
		if (csm.character.moveInput.magnitude > 0.1)
		{
			csm.ChangeState(csm.moveState);
		}
	}
}
