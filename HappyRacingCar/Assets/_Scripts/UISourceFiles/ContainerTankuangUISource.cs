/* UISource File Create Data: 1/1/2019 9:56:09 PM*/

using UnityEngine;

public partial class ContainerTankuangUIController : UIControllerBase
{
	private GameObject maskBackGround;
	private Vector3 uiOriginalPositionMaskBackGround;
	private GameObject backGround;
	private Vector3 uiOriginalPositionBackGround;
	private GameObject closeButton;
	private Vector3 uiOriginalPositionCloseButton;
	private GameObject jingQingQiDaiText;
	private Vector3 uiOriginalPositionJingQingQiDaiText;


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
	public GameObject JingQingQiDaiText
	{
		get
		{
			if (jingQingQiDaiText == null)
			{
				jingQingQiDaiText = this.transform.Find("JingQingQiDaiText").gameObject;
				uiOriginalPositionJingQingQiDaiText = jingQingQiDaiText.transform.localPosition;
			}
			return jingQingQiDaiText;
		} 
	}
	public Vector3 UIOriginalPositionJingQingQiDaiText
	{
		get
		{
			if (jingQingQiDaiText == null)
			{
				return JingQingQiDaiText.transform.localPosition;
			}
			return uiOriginalPositionJingQingQiDaiText;
		} 
	}
}
