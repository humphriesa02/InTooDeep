using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class Wander : Node
{
	NonPlayableCharacter npc;
	private float waitCounter = 0f;
	private bool waiting = true;
	private Vector3 wanderPosition = Vector2.zero;

	public Wander(NonPlayableCharacter character)
	{
		npc = character;
	}

	public override NodeState Evaluate()
	{
		// Wait
		if (waiting)
		{
			waitCounter += Time.deltaTime;
			if (waitCounter >= npc.waitTime) // Back to moving
			{
				waiting = false;
				wanderPosition = GenerateViableMovePoint();
			}
		}
		else
		{
			if (Vector3.Distance(npc.transform.position, wanderPosition) < 0.01f) // We have gotten close enough to wander position, wait
			{
				waiting = true;
				waitCounter = 0f;
				npc.moveInput = Vector2.zero;
			}
			else // Move to wander position
			{
				npc.moveInput = new Vector2(wanderPosition.x - npc.transform.position.x, wanderPosition.z - npc.transform.position.z);
				npc.moveInput.Normalize();
			}

		}

		state = NodeState.RUNNING;
		return state;
	}

	/// <summary>
	/// Find a place locally, relative to the object,
	/// that they are able to move to.
	/// </summary>
	/// <returns></returns>
	private Vector3 GenerateViableMovePoint()
	{
		float randX = Random.Range(-5f, 5f);
		float randZ = Random.Range(-5f, 5f);
		Vector3 newMovePoint = new Vector3(npc.transform.position.x + randX, npc.transform.position.y, npc.transform.position.z + randZ);

		return newMovePoint;
	}
}
