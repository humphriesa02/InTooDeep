using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
	public static HUD Instance;
	// Task board to be used by player to command researchers
	public GameObject TaskBoard;
	private bool isTaskBoardVisible = false;
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
	public void SetTaskBoardVisibility()
    {
		isTaskBoardVisible = !isTaskBoardVisible;
        TaskBoard.SetActive(isTaskBoardVisible);
		if (isTaskBoardVisible)
		{
			TaskBoard.GetComponent<TaskBoard>().PopulateListView();
		}
		else
		{
			TaskBoard.GetComponent<TaskBoard>().TearDownListView();
		}
    }
}
