using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResearcherUI : MonoBehaviour
{
    [SerializeField] private Image researcherImage;
	[SerializeField] private TextMeshProUGUI researcherNameText;
	[SerializeField] private Image taskStatusImage;
	public void SetResearcherImage(Image image)
	{
		researcherImage = image;
	}

	public void SetResearcherNameText(string name)
    {
		researcherNameText.text = name;
    }

	public void SetTaskStatusImage(Image image)
	{
		taskStatusImage = image;
	}
   
}
