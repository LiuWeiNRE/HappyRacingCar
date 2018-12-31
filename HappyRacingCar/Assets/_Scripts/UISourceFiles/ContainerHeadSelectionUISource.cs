/* UISource File Create Data: 12/31/2018 9:04:25 PM*/

using UnityEngine;

public partial class ContainerHeadSelectionUIController : UIControllerBase
{
	private GameObject maskBackGround;
	private Vector3 uiOriginalPositionMaskBackGround;
	private GameObject backGround;
	private Vector3 uiOriginalPositionBackGround;
	private GameObject headList;
	private Vector3 uiOriginalPositionHeadList;
	private GameObject closeButton;
	private Vector3 uiOriginalPositionCloseButton;


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
	public GameObject HeadList
	{
		get
		{
			if (headList == null)
			{
				headList = this.transform.Find("HeadList").gameObject;
				uiOriginalPositionHeadList = headList.transform.localPosition;
			}
			return headList;
		} 
	}
	public Vector3 UIOriginalPositionHeadList
	{
		get
		{
			if (headList == null)
			{
				return HeadList.transform.localPosition;
			}
			return uiOriginalPositionHeadList;
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
}
