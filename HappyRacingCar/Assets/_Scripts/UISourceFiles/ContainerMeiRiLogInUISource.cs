/* UISource File Create Data: 12/25/2018 11:35:59 PM*/

using UnityEngine;

public partial class ContainerMeiRiLogInUIController : UIControllerBase
{
	private GameObject maskBackGround;
	private Vector3 uiOriginalPositionMaskBackGround;
	private GameObject backGround;
	private Vector3 uiOriginalPositionBackGround;
	private GameObject oKButton;
	private Vector3 uiOriginalPositionOKButton;
	private GameObject firstDayPrize;
	private Vector3 uiOriginalPositionFirstDayPrize;
	private GameObject secondDayPrize;
	private Vector3 uiOriginalPositionSecondDayPrize;
	private GameObject thirdDayPrize;
	private Vector3 uiOriginalPositionThirdDayPrize;
	private GameObject fourthDayPrize;
	private Vector3 uiOriginalPositionFourthDayPrize;
	private GameObject fifthDayPrize;
	private Vector3 uiOriginalPositionFifthDayPrize;
	private GameObject sixthDayPrize;
	private Vector3 uiOriginalPositionSixthDayPrize;
	private GameObject seventhDayPrize;
	private Vector3 uiOriginalPositionSeventhDayPrize;


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
	public GameObject OKButton
	{
		get
		{
			if (oKButton == null)
			{
				oKButton = this.transform.Find("OKButton").gameObject;
				uiOriginalPositionOKButton = oKButton.transform.localPosition;
			}
			return oKButton;
		} 
	}
	public Vector3 UIOriginalPositionOKButton
	{
		get
		{
			if (oKButton == null)
			{
				return OKButton.transform.localPosition;
			}
			return uiOriginalPositionOKButton;
		} 
	}
	public GameObject FirstDayPrize
	{
		get
		{
			if (firstDayPrize == null)
			{
				firstDayPrize = this.transform.Find("FirstDayPrize").gameObject;
				uiOriginalPositionFirstDayPrize = firstDayPrize.transform.localPosition;
			}
			return firstDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionFirstDayPrize
	{
		get
		{
			if (firstDayPrize == null)
			{
				return FirstDayPrize.transform.localPosition;
			}
			return uiOriginalPositionFirstDayPrize;
		} 
	}
	public GameObject SecondDayPrize
	{
		get
		{
			if (secondDayPrize == null)
			{
				secondDayPrize = this.transform.Find("SecondDayPrize").gameObject;
				uiOriginalPositionSecondDayPrize = secondDayPrize.transform.localPosition;
			}
			return secondDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionSecondDayPrize
	{
		get
		{
			if (secondDayPrize == null)
			{
				return SecondDayPrize.transform.localPosition;
			}
			return uiOriginalPositionSecondDayPrize;
		} 
	}
	public GameObject ThirdDayPrize
	{
		get
		{
			if (thirdDayPrize == null)
			{
				thirdDayPrize = this.transform.Find("ThirdDayPrize").gameObject;
				uiOriginalPositionThirdDayPrize = thirdDayPrize.transform.localPosition;
			}
			return thirdDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionThirdDayPrize
	{
		get
		{
			if (thirdDayPrize == null)
			{
				return ThirdDayPrize.transform.localPosition;
			}
			return uiOriginalPositionThirdDayPrize;
		} 
	}
	public GameObject FourthDayPrize
	{
		get
		{
			if (fourthDayPrize == null)
			{
				fourthDayPrize = this.transform.Find("FourthDayPrize").gameObject;
				uiOriginalPositionFourthDayPrize = fourthDayPrize.transform.localPosition;
			}
			return fourthDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionFourthDayPrize
	{
		get
		{
			if (fourthDayPrize == null)
			{
				return FourthDayPrize.transform.localPosition;
			}
			return uiOriginalPositionFourthDayPrize;
		} 
	}
	public GameObject FifthDayPrize
	{
		get
		{
			if (fifthDayPrize == null)
			{
				fifthDayPrize = this.transform.Find("FifthDayPrize").gameObject;
				uiOriginalPositionFifthDayPrize = fifthDayPrize.transform.localPosition;
			}
			return fifthDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionFifthDayPrize
	{
		get
		{
			if (fifthDayPrize == null)
			{
				return FifthDayPrize.transform.localPosition;
			}
			return uiOriginalPositionFifthDayPrize;
		} 
	}
	public GameObject SixthDayPrize
	{
		get
		{
			if (sixthDayPrize == null)
			{
				sixthDayPrize = this.transform.Find("SixthDayPrize").gameObject;
				uiOriginalPositionSixthDayPrize = sixthDayPrize.transform.localPosition;
			}
			return sixthDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionSixthDayPrize
	{
		get
		{
			if (sixthDayPrize == null)
			{
				return SixthDayPrize.transform.localPosition;
			}
			return uiOriginalPositionSixthDayPrize;
		} 
	}
	public GameObject SeventhDayPrize
	{
		get
		{
			if (seventhDayPrize == null)
			{
				seventhDayPrize = this.transform.Find("SeventhDayPrize").gameObject;
				uiOriginalPositionSeventhDayPrize = seventhDayPrize.transform.localPosition;
			}
			return seventhDayPrize;
		} 
	}
	public Vector3 UIOriginalPositionSeventhDayPrize
	{
		get
		{
			if (seventhDayPrize == null)
			{
				return SeventhDayPrize.transform.localPosition;
			}
			return uiOriginalPositionSeventhDayPrize;
		} 
	}
}
