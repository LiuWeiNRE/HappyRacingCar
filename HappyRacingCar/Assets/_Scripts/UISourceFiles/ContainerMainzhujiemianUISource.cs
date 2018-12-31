/* UISource File Create Data: 12/31/2018 9:04:40 PM*/

using UnityEngine;

public partial class ContainerMainzhujiemianUIController : UIControllerBase
{
	private GameObject headPortraitButton;
	private Vector3 uiOriginalPositionHeadPortraitButton;


	public GameObject HeadPortraitButton
	{
		get
		{
			if (headPortraitButton == null)
			{
				headPortraitButton = this.transform.Find("HeadPortraitButton").gameObject;
				uiOriginalPositionHeadPortraitButton = headPortraitButton.transform.localPosition;
			}
			return headPortraitButton;
		} 
	}
	public Vector3 UIOriginalPositionHeadPortraitButton
	{
		get
		{
			if (headPortraitButton == null)
			{
				return HeadPortraitButton.transform.localPosition;
			}
			return uiOriginalPositionHeadPortraitButton;
		} 
	}
}
