using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class GoToTarget : Node
{
	NonPlayableCharacter npc;

	public GoToTarget(NonPlayableCharacter character)
	{
		npc = character;
	}

	public override NodeState Evaluate()
	{
		Transform target = (Transform)GetData("Target");
        if (Vector3.Distance(npc.transform.position, target.position) > 0.01f)
        {
			npc.moveInput = new Vector2(target.position.x - npc.transform.position.x, target.position.z - npc.transform.position.z);
			npc.moveInput.Normalize();
		}

		state = NodeState.RUNNING;
		return state;
    }
}
