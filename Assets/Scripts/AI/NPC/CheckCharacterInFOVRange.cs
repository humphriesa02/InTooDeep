using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorTree;

public class CheckCharacterInFOVRange : Node
{
	NonPlayableCharacter npc;
	private static int characterLayerMask = 1 << 2;
	public CheckCharacterInFOVRange(NonPlayableCharacter character)
	{
		npc = character;
	}

	public override NodeState Evaluate()
	{
		object t = GetData("Target");
		if (t == null)
		{
			Collider[] colliders = Physics.OverlapSphere(
				npc.transform.position,
				npc.fovRange
				);
			foreach (Collider collider in colliders)
			{
				if (collider.gameObject.CompareTag("Player"))
				{
					parent.parent.SetData("Target", collider.transform);
					state = NodeState.SUCCESS;
					return state;
				}
			}
			state = NodeState.FAILURE;
			return state;
		}
		state = NodeState.SUCCESS;
		return state;
	}
}
