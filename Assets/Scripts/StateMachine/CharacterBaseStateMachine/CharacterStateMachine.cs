using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine : StateMachine
{
	// Available "states" for a player. What they can do at any given time.
	// Does not handle input.
	public MoveState moveState;
	public IdleState idleState;
	public Character character { get; private set; }

	public CharacterStateMachine(Character ch)
	{ 
		character = ch;
		moveState = new MoveState(this);
		idleState = new IdleState(this);
	}
}
