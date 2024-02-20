using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorTree;

public class AwaitNewTask : Node
{
	NonPlayableCharacter npc;
	public AwaitNewTask(NonPlayableCharacter character)
	{
		npc = character;
	}

	public override NodeState Evaluate()
	{
		// Check if we have a target to move to
		object t = GetData("Target");
		if (t == null)
		{
			// Task has been assigned, we can move to it
			if (npc.task != null)
			{
				parent.parent.SetData("Target", npc.task.transform);
				state = NodeState.SUCCESS;
				return state;
			}
			state = NodeState.FAILURE;
			return state;
		}

		state = NodeState.SUCCESS;
		return state;
	}
}
