using System.Collections;
using System.Collections.Generic;
using BehaviorTree;

public class NPCBehaviorTree : Tree
{
    NonPlayableCharacter npc;
    public NPCBehaviorTree(NonPlayableCharacter character)
    {
        npc = character;
    }
    protected override Node SetupTree()
    {
        Node root = new Selector(new List<Node>
        {
            new Sequence(new List<Node>
            {
                new AwaitNewTask(npc),
                new GoToTarget(npc)
            }),
            new Wander(npc),
        });

        return root;
    }
}
