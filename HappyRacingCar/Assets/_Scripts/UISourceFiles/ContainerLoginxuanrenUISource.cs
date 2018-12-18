/* UISource File Create Data: 12/18/2018 10:17:14 PM*/

using UnityEngine;

public partial class ContainerLoginxuanrenUIController : UIControllerBase
{
	private GameObject backGround;
	private Vector3 uiOriginalPositionBackGround;
	private GameObject heJiongToggle;
	private Vector3 uiOriginalPositionHeJiongToggle;
	private GameObject xieNaToggle;
	private Vector3 uiOriginalPositionXieNaToggle;
	private GameObject wuXinToggle;
	private Vector3 uiOriginalPositionWuXinToggle;
	private GameObject weiJiaToggle;
	private Vector3 uiOriginalPositionWeiJiaToggle;
	private GameObject duHaiTaoToggle;
	private Vector3 uiOriginalPositionDuHaiTaoToggle;
	private GameObject sexBoyToggle;
	private Vector3 uiOriginalPositionSexBoyToggle;
	private GameObject sexGirlToggle;
	private Vector3 uiOriginalPositionSexGirlToggle;
	private GameObject playerNameInputField;
	private Vector3 uiOriginalPositionPlayerNameInputField;
	private GameObject shaiZiButton;
	private Vector3 uiOriginalPositionShaiZiButton;
	private GameObject hintText;
	private Vector3 uiOriginalPositionHintText;
	private GameObject pressEnterButton;
	private Vector3 uiOriginalPositionPressEnterButton;


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
	public GameObject HeJiongToggle
	{
		get
		{
			if (heJiongToggle == null)
			{
				heJiongToggle = this.transform.Find("HeJiongToggle").gameObject;
				uiOriginalPositionHeJiongToggle = heJiongToggle.transform.localPosition;
			}
			return heJiongToggle;
		} 
	}
	public Vector3 UIOriginalPositionHeJiongToggle
	{
		get
		{
			if (heJiongToggle == null)
			{
				return HeJiongToggle.transform.localPosition;
			}
			return uiOriginalPositionHeJiongToggle;
		} 
	}
	public GameObject XieNaToggle
	{
		get
		{
			if (xieNaToggle == null)
			{
				xieNaToggle = this.transform.Find("XieNaToggle").gameObject;
				uiOriginalPositionXieNaToggle = xieNaToggle.transform.localPosition;
			}
			return xieNaToggle;
		} 
	}
	public Vector3 UIOriginalPositionXieNaToggle
	{
		get
		{
			if (xieNaToggle == null)
			{
				return XieNaToggle.transform.localPosition;
			}
			return uiOriginalPositionXieNaToggle;
		} 
	}
	public GameObject WuXinToggle
	{
		get
		{
			if (wuXinToggle == null)
			{
				wuXinToggle = this.transform.Find("WuXinToggle").gameObject;
				uiOriginalPositionWuXinToggle = wuXinToggle.transform.localPosition;
			}
			return wuXinToggle;
		} 
	}
	public Vector3 UIOriginalPositionWuXinToggle
	{
		get
		{
			if (wuXinToggle == null)
			{
				return WuXinToggle.transform.localPosition;
			}
			return uiOriginalPositionWuXinToggle;
		} 
	}
	public GameObject WeiJiaToggle
	{
		get
		{
			if (weiJiaToggle == null)
			{
				weiJiaToggle = this.transform.Find("WeiJiaToggle").gameObject;
				uiOriginalPositionWeiJiaToggle = weiJiaToggle.transform.localPosition;
			}
			return weiJiaToggle;
		} 
	}
	public Vector3 UIOriginalPositionWeiJiaToggle
	{
		get
		{
			if (weiJiaToggle == null)
			{
				return WeiJiaToggle.transform.localPosition;
			}
			return uiOriginalPositionWeiJiaToggle;
		} 
	}
	public GameObject DuHaiTaoToggle
	{
		get
		{
			if (duHaiTaoToggle == null)
			{
				duHaiTaoToggle = this.transform.Find("DuHaiTaoToggle").gameObject;
				uiOriginalPositionDuHaiTaoToggle = duHaiTaoToggle.transform.localPosition;
			}
			return duHaiTaoToggle;
		} 
	}
	public Vector3 UIOriginalPositionDuHaiTaoToggle
	{
		get
		{
			if (duHaiTaoToggle == null)
			{
				return DuHaiTaoToggle.transform.localPosition;
			}
			return uiOriginalPositionDuHaiTaoToggle;
		} 
	}
	public GameObject SexBoyToggle
	{
		get
		{
			if (sexBoyToggle == null)
			{
				sexBoyToggle = this.transform.Find("SexBoyToggle").gameObject;
				uiOriginalPositionSexBoyToggle = sexBoyToggle.transform.localPosition;
			}
			return sexBoyToggle;
		} 
	}
	public Vector3 UIOriginalPositionSexBoyToggle
	{
		get
		{
			if (sexBoyToggle == null)
			{
				return SexBoyToggle.transform.localPosition;
			}
			return uiOriginalPositionSexBoyToggle;
		} 
	}
	public GameObject SexGirlToggle
	{
		get
		{
			if (sexGirlToggle == null)
			{
				sexGirlToggle = this.transform.Find("SexGirlToggle").gameObject;
				uiOriginalPositionSexGirlToggle = sexGirlToggle.transform.localPosition;
			}
			return sexGirlToggle;
		} 
	}
	public Vector3 UIOriginalPositionSexGirlToggle
	{
		get
		{
			if (sexGirlToggle == null)
			{
				return SexGirlToggle.transform.localPosition;
			}
			return uiOriginalPositionSexGirlToggle;
		} 
	}
	public GameObject PlayerNameInputField
	{
		get
		{
			if (playerNameInputField == null)
			{
				playerNameInputField = this.transform.Find("PlayerNameInputField").gameObject;
				uiOriginalPositionPlayerNameInputField = playerNameInputField.transform.localPosition;
			}
			return playerNameInputField;
		} 
	}
	public Vector3 UIOriginalPositionPlayerNameInputField
	{
		get
		{
			if (playerNameInputField == null)
			{
				return PlayerNameInputField.transform.localPosition;
			}
			return uiOriginalPositionPlayerNameInputField;
		} 
	}
	public GameObject ShaiZiButton
	{
		get
		{
			if (shaiZiButton == null)
			{
				shaiZiButton = this.transform.Find("ShaiZiButton").gameObject;
				uiOriginalPositionShaiZiButton = shaiZiButton.transform.localPosition;
			}
			return shaiZiButton;
		} 
	}
	public Vector3 UIOriginalPositionShaiZiButton
	{
		get
		{
			if (shaiZiButton == null)
			{
				return ShaiZiButton.transform.localPosition;
			}
			return uiOriginalPositionShaiZiButton;
		} 
	}
	public GameObject HintText
	{
		get
		{
			if (hintText == null)
			{
				hintText = this.transform.Find("HintText").gameObject;
				uiOriginalPositionHintText = hintText.transform.localPosition;
			}
			return hintText;
		} 
	}
	public Vector3 UIOriginalPositionHintText
	{
		get
		{
			if (hintText == null)
			{
				return HintText.transform.localPosition;
			}
			return uiOriginalPositionHintText;
		} 
	}
	public GameObject PressEnterButton
	{
		get
		{
			if (pressEnterButton == null)
			{
				pressEnterButton = this.transform.Find("PressEnterButton").gameObject;
				uiOriginalPositionPressEnterButton = pressEnterButton.transform.localPosition;
			}
			return pressEnterButton;
		} 
	}
	public Vector3 UIOriginalPositionPressEnterButton
	{
		get
		{
			if (pressEnterButton == null)
			{
				return PressEnterButton.transform.localPosition;
			}
			return uiOriginalPositionPressEnterButton;
		} 
	}
}
