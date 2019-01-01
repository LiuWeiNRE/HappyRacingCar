/* UISource File Create Data: 1/1/2019 10:31:37 PM*/

using UnityEngine;

public partial class ContainerSetUpUIController : UIControllerBase
{
	private GameObject maskBackGround;
	private Vector3 uiOriginalPositionMaskBackGround;
	private GameObject backGround;
	private Vector3 uiOriginalPositionBackGround;
	private GameObject closeButton;
	private Vector3 uiOriginalPositionCloseButton;
	private GameObject aboutGameText;
	private Vector3 uiOriginalPositionAboutGameText;
	private GameObject musicONButton;
	private Vector3 uiOriginalPositionMusicONButton;
	private GameObject musicOFFButton;
	private Vector3 uiOriginalPositionMusicOFFButton;
	private GameObject musicEffectONButton;
	private Vector3 uiOriginalPositionMusicEffectONButton;
	private GameObject musicEffectOFFButton;
	private Vector3 uiOriginalPositionMusicEffectOFFButton;


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
	public GameObject AboutGameText
	{
		get
		{
			if (aboutGameText == null)
			{
				aboutGameText = this.transform.Find("AboutGameText").gameObject;
				uiOriginalPositionAboutGameText = aboutGameText.transform.localPosition;
			}
			return aboutGameText;
		} 
	}
	public Vector3 UIOriginalPositionAboutGameText
	{
		get
		{
			if (aboutGameText == null)
			{
				return AboutGameText.transform.localPosition;
			}
			return uiOriginalPositionAboutGameText;
		} 
	}
	public GameObject MusicONButton
	{
		get
		{
			if (musicONButton == null)
			{
				musicONButton = this.transform.Find("MusicONButton").gameObject;
				uiOriginalPositionMusicONButton = musicONButton.transform.localPosition;
			}
			return musicONButton;
		} 
	}
	public Vector3 UIOriginalPositionMusicONButton
	{
		get
		{
			if (musicONButton == null)
			{
				return MusicONButton.transform.localPosition;
			}
			return uiOriginalPositionMusicONButton;
		} 
	}
	public GameObject MusicOFFButton
	{
		get
		{
			if (musicOFFButton == null)
			{
				musicOFFButton = this.transform.Find("MusicOFFButton").gameObject;
				uiOriginalPositionMusicOFFButton = musicOFFButton.transform.localPosition;
			}
			return musicOFFButton;
		} 
	}
	public Vector3 UIOriginalPositionMusicOFFButton
	{
		get
		{
			if (musicOFFButton == null)
			{
				return MusicOFFButton.transform.localPosition;
			}
			return uiOriginalPositionMusicOFFButton;
		} 
	}
	public GameObject MusicEffectONButton
	{
		get
		{
			if (musicEffectONButton == null)
			{
				musicEffectONButton = this.transform.Find("MusicEffectONButton").gameObject;
				uiOriginalPositionMusicEffectONButton = musicEffectONButton.transform.localPosition;
			}
			return musicEffectONButton;
		} 
	}
	public Vector3 UIOriginalPositionMusicEffectONButton
	{
		get
		{
			if (musicEffectONButton == null)
			{
				return MusicEffectONButton.transform.localPosition;
			}
			return uiOriginalPositionMusicEffectONButton;
		} 
	}
	public GameObject MusicEffectOFFButton
	{
		get
		{
			if (musicEffectOFFButton == null)
			{
				musicEffectOFFButton = this.transform.Find("MusicEffectOFFButton").gameObject;
				uiOriginalPositionMusicEffectOFFButton = musicEffectOFFButton.transform.localPosition;
			}
			return musicEffectOFFButton;
		} 
	}
	public Vector3 UIOriginalPositionMusicEffectOFFButton
	{
		get
		{
			if (musicEffectOFFButton == null)
			{
				return MusicEffectOFFButton.transform.localPosition;
			}
			return uiOriginalPositionMusicEffectOFFButton;
		} 
	}
}
