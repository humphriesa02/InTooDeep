using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The "actions" a car can take in the car model.
/// 
/// Different states of logic that can be executed by a state machine.
/// </summary>
public interface State
{
	public void OnBegin(StateMachine sc);
	public void OnUpdate();
	public void OnPhysicsUpdate();
	public void OnExit();
	public void CheckForInput();
}
