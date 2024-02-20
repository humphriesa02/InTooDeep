using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TaskBoard : MonoBehaviour
{
	[SerializeField] private GameObject researcherList;
	[SerializeField] private GameObject researcherUIPrefab;

	public void PopulateListView()
	{
		foreach (NonPlayableCharacter npc in GameManager.Instance.npcList)
		{
			GameObject researcherObj = Instantiate(researcherUIPrefab, researcherList.transform);

			//researcherObj.GetComponent<ResearcherUI>().SetResearcherImage(npc.Image);
			researcherObj.GetComponent<ResearcherUI>().SetResearcherNameText(npc.characterName);
		}
	}

	public void TearDownListView()
	{
		foreach (Transform child in researcherList.transform)
		{
			Destroy(child.gameObject);
		}
	}
}
