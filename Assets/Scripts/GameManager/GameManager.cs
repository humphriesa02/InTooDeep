using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Singleton to handle overall game logic
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject player;

	public List<NonPlayableCharacter> npcList;

	public List<Task> taskList;


	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	private void Start()
	{
		if (player == null)
		{
			player = GameObject.FindGameObjectWithTag("Player");
		}
		if (npcList.Count == 0)
		{
			GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");
			foreach (GameObject npc in npcs)
			{
				npcList.Add(npc.GetComponent<NonPlayableCharacter>());
			}
		}
		if (taskList.Count == 0)
		{
			PopulateTaskList();
		}
	}

	private void PopulateTaskList()
	{

	}
}
