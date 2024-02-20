using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
	public abstract class Tree
	{
		private Node root = null;

		public void OnBegin()
		{
			root = SetupTree();
		}
		public void OnEvaluate()
		{
			if (root != null)
			{
				root.Evaluate();
			}
		}

		protected abstract Node SetupTree();
	}
}