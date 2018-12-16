/* UISource File Create Data: 12/16/2018 10:20:29 PM*/

using UnityEngine;

public partial class DebugFPSUIController : UIControllerBase
{
	private GameObject fPSText;
	private Vector3 uiOriginalPositionFPSText;


	public GameObject FPSText
	{
		get
		{
			if (fPSText == null)
			{
				fPSText = this.transform.Find("FPSText").gameObject;
				uiOriginalPositionFPSText = fPSText.transform.localPosition;
			}
			return fPSText;
		} 
	}
	public Vector3 UIOriginalPositionFPSText
	{
		get
		{
			if (fPSText == null)
			{
				return FPSText.transform.localPosition;
			}
			return uiOriginalPositionFPSText;
		} 
	}
}
