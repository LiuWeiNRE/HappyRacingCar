/* UISource File Create Data: 1/1/2019 9:48:35 PM*/

using UnityEngine;

public partial class ContainerMainzhujiemianUIController : UIControllerBase
{
	private GameObject headPortraitButton;
	private Vector3 uiOriginalPositionHeadPortraitButton;
	private GameObject setUpButton;
	private Vector3 uiOriginalPositionSetUpButton;
	private GameObject noticeButton;
	private Vector3 uiOriginalPositionNoticeButton;
	private GameObject goodFriendButton;
	private Vector3 uiOriginalPositionGoodFriendButton;


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
	public GameObject SetUpButton
	{
		get
		{
			if (setUpButton == null)
			{
				setUpButton = this.transform.Find("SetUpButton").gameObject;
				uiOriginalPositionSetUpButton = setUpButton.transform.localPosition;
			}
			return setUpButton;
		} 
	}
	public Vector3 UIOriginalPositionSetUpButton
	{
		get
		{
			if (setUpButton == null)
			{
				return SetUpButton.transform.localPosition;
			}
			return uiOriginalPositionSetUpButton;
		} 
	}
	public GameObject NoticeButton
	{
		get
		{
			if (noticeButton == null)
			{
				noticeButton = this.transform.Find("NoticeButton").gameObject;
				uiOriginalPositionNoticeButton = noticeButton.transform.localPosition;
			}
			return noticeButton;
		} 
	}
	public Vector3 UIOriginalPositionNoticeButton
	{
		get
		{
			if (noticeButton == null)
			{
				return NoticeButton.transform.localPosition;
			}
			return uiOriginalPositionNoticeButton;
		} 
	}
	public GameObject GoodFriendButton
	{
		get
		{
			if (goodFriendButton == null)
			{
				goodFriendButton = this.transform.Find("GoodFriendButton").gameObject;
				uiOriginalPositionGoodFriendButton = goodFriendButton.transform.localPosition;
			}
			return goodFriendButton;
		} 
	}
	public Vector3 UIOriginalPositionGoodFriendButton
	{
		get
		{
			if (goodFriendButton == null)
			{
				return GoodFriendButton.transform.localPosition;
			}
			return uiOriginalPositionGoodFriendButton;
		} 
	}
}
