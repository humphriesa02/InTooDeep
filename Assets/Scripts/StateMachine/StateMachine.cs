using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Engine of the car in the car model.
/// 
/// Base class for State Machine.
/// Most if not all entity logic (movable character ish types) will be handled in this logic.
/// </summary>
public class StateMachine
{
    private State currentState;

	// Leave the current state and enter the new state
	public void ChangeState(State State)
    {
        if (currentState != null)
        {
			currentState.OnExit();
		}

		if (currentState != State)
		{
			currentState = State;
            currentState.OnBegin(this);
        }
    }

    // Call whatever functionality the current state does every frame
    public void UpdateState()
    {
        if (currentState != null)
        {
			currentState.OnUpdate();
        }
    }

    public void PhysicsUpdateState()
    {
		if (currentState != null)
		{
			currentState.OnPhysicsUpdate();
		}
	}
}
