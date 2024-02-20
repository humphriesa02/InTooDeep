
public class NonPlayableCharacter : Character
{
	public float waitTime = 1f;
	NPCBehaviorTree bt;
	public float fovRange = 6f;
	public Task task;

	private void Awake()
	{
		bt = new NPCBehaviorTree(this);
	}

	protected override void Start()
	{
		base.Start();
		bt.OnBegin();
	}

	// NPC gets input from AI
	protected override void PollInput()
	{
		bt.OnEvaluate();
	}
}
