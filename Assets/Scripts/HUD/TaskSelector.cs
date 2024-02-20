using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskSelector : MonoBehaviour
{
	[SerializeField] private GameObject taskList;
	[SerializeField] private GameObject taskUIPrefab;

	public void PopulateListView()
	{
		foreach (NonPlayableCharacter npc in GameManager.Instance.npcList)
		{
			GameObject taskObj = Instantiate(taskUIPrefab, taskList.transform);

			//taskObj.GetComponent<taskUI>().SettaskImage(npc.Image);
			//researcherObj.GetComponent<ResearcherUI>().SetResearcherNameText(npc.characterName);
		}
	}

	public void TearDownListView()
	{
		foreach (Transform child in taskList.transform)
		{
			Destroy(child.gameObject);
		}
	}
}
