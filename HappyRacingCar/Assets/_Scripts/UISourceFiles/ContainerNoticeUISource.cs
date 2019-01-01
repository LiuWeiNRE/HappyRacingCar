/* UISource File Create Data: 1/1/2019 10:18:09 PM*/

using UnityEngine;

public partial class ContainerNoticeUIController : UIControllerBase
{
	private GameObject maskBackGround;
	private Vector3 uiOriginalPositionMaskBackGround;
	private GameObject backGround;
	private Vector3 uiOriginalPositionBackGround;
	private GameObject closeButton;
	private Vector3 uiOriginalPositionCloseButton;
	private GameObject noticeText;
	private Vector3 uiOriginalPositionNoticeText;


	public GameObject MaskBackGround
	{
		get
		{
			if (maskBackGround == null)
			{
				maskBackGround = this.transform.Find("MaskBackGround").gameObject;
				uiOriginalPositionMaskBackGround = maskBackGround.transform.localPosition;
			}
			return maskBackGround;
		} 
	}
	public Vector3 UIOriginalPositionMaskBackGround
	{
		get
		{
			if (maskBackGround == null)
			{
				return MaskBackGround.transform.localPosition;
			}
			return uiOriginalPositionMaskBackGround;
		} 
	}
	public GameObject BackGround
	{
		get
		{
			if (backGround == null)
			{
				backGround = this.transform.Find("BackGround").gameObject;
				uiOriginalPositionBackGround = backGround.transform.localPosition;
			}
			return backGround;
		} 
	}
	public Vector3 UIOriginalPositionBackGround
	{
		get
		{
			if (backGround == null)
			{
				return BackGround.transform.localPosition;
			}
			return uiOriginalPositionBackGround;
		} 
	}
	public GameObject CloseButton
	{
		get
		{
			if (closeButton == null)
			{
				closeButton = this.transform.Find("CloseButton").gameObject;
				uiOriginalPositionCloseButton = closeButton.transform.localPosition;
			}
			return closeButton;
		} 
	}
	public Vector3 UIOriginalPositionCloseButton
	{
		get
		{
			if (closeButton == null)
			{
				return CloseButton.transform.localPosition;
			}
			return uiOriginalPositionCloseButton;
		} 
	}
	public GameObject NoticeText
	{
		get
		{
			if (noticeText == null)
			{
				noticeText = this.transform.Find("NoticeText").gameObject;
				uiOriginalPositionNoticeText = noticeText.transform.localPosition;
			}
			return noticeText;
		} 
	}
	public Vector3 UIOriginalPositionNoticeText
	{
		get
		{
			if (noticeText == null)
			{
				return NoticeText.transform.localPosition;
			}
			return uiOriginalPositionNoticeText;
		} 
	}
}
