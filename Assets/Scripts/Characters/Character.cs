using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The "Car" in a car model.
/// 
/// Holds everything that makes up a singular "character".
/// Connects input with logic with end result.
/// </summary>
public class Character : MonoBehaviour
{
	public string characterName;

    /**
     * Movement settings
     */
    [Header("Movement Settings")]
	public Vector2 moveInput; // Can be led by users or AI
	public float walkSpeed;
    public float runSpeed;
    public bool isRunning = false;

	/**
     * Interaction settings
     */
	[Header("Interaction settings")]
	public bool interactButtonPressed;

	/**
     * Menu settings
     */
	[Header("Menu settings")]
	public bool menuButtonPressed;

	/**
     * Components
     */
	
	public Animator anim { get; private set; }
    public Rigidbody rb { get; private set; }
	private CharacterStateMachine characterSM;

	[Header("Components")]
	public Stats stats;
	// Start is called before the first frame update

    protected virtual void Awake()
    {
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		characterSM = new CharacterStateMachine(this);
	}

	protected virtual void Start()
    {
        if (characterSM != null)
        {
            characterSM.ChangeState(characterSM.idleState);
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
		// Drive the StateMachine
		if (characterSM != null) characterSM.UpdateState();
		// Poll for input
		PollInput();
    }

	private void FixedUpdate()
	{
		if (characterSM != null) characterSM.PhysicsUpdateState();
	}

	protected virtual void PollInput()
    {

    }
}
