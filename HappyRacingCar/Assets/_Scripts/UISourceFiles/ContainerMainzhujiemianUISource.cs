/* UISource File Create Data: 11/2/2019 4:19:31 PM*/

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
    private GameObject jiaHaoTiLiButton;
    private Vector3 uiOriginalPositionJiaHaoTiLiButton;
    private GameObject jiaHaoZuanShiButton;
    private Vector3 uiOriginalPositionJiaHaoZuanShiButton;
    private GameObject jiaHaoJinBiButton;
    private Vector3 uiOriginalPositionJiaHaoJinBiButton;
    private GameObject tiLiShuZiText;
    private Vector3 uiOriginalPositionTiLiShuZiText;
    private GameObject jinBiShuZiText;
    private Vector3 uiOriginalPositionJinBiShuZiText;
    private GameObject zuanShiShuZiText;
    private Vector3 uiOriginalPositionZuanShiShuZiText;


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
    public GameObject JiaHaoTiLiButton
    {
        get
        {
            if (jiaHaoTiLiButton == null)
            {
                jiaHaoTiLiButton = this.transform.Find("JiaHaoTiLiButton").gameObject;
                uiOriginalPositionJiaHaoTiLiButton = jiaHaoTiLiButton.transform.localPosition;
            }
            return jiaHaoTiLiButton;
        }
    }
    public Vector3 UIOriginalPositionJiaHaoTiLiButton
    {
        get
        {
            if (jiaHaoTiLiButton == null)
            {
                return JiaHaoTiLiButton.transform.localPosition;
            }
            return uiOriginalPositionJiaHaoTiLiButton;
        }
    }
    public GameObject JiaHaoZuanShiButton
    {
        get
        {
            if (jiaHaoZuanShiButton == null)
            {
                jiaHaoZuanShiButton = this.transform.Find("JiaHaoZuanShiButton").gameObject;
                uiOriginalPositionJiaHaoZuanShiButton = jiaHaoZuanShiButton.transform.localPosition;
            }
            return jiaHaoZuanShiButton;
        }
    }
    public Vector3 UIOriginalPositionJiaHaoZuanShiButton
    {
        get
        {
            if (jiaHaoZuanShiButton == null)
            {
                return JiaHaoZuanShiButton.transform.localPosition;
            }
            return uiOriginalPositionJiaHaoZuanShiButton;
        }
    }
    public GameObject JiaHaoJinBiButton
    {
        get
        {
            if (jiaHaoJinBiButton == null)
            {
                jiaHaoJinBiButton = this.transform.Find("JiaHaoJinBiButton").gameObject;
                uiOriginalPositionJiaHaoJinBiButton = jiaHaoJinBiButton.transform.localPosition;
            }
            return jiaHaoJinBiButton;
        }
    }
    public Vector3 UIOriginalPositionJiaHaoJinBiButton
    {
        get
        {
            if (jiaHaoJinBiButton == null)
            {
                return JiaHaoJinBiButton.transform.localPosition;
            }
            return uiOriginalPositionJiaHaoJinBiButton;
        }
    }
    public GameObject TiLiShuZiText
    {
        get
        {
            if (tiLiShuZiText == null)
            {
                tiLiShuZiText = this.transform.Find("TiLiShuZiText").gameObject;
                uiOriginalPositionTiLiShuZiText = tiLiShuZiText.transform.localPosition;
            }
            return tiLiShuZiText;
        }
    }
    public Vector3 UIOriginalPositionTiLiShuZiText
    {
        get
        {
            if (tiLiShuZiText == null)
            {
                return TiLiShuZiText.transform.localPosition;
            }
            return uiOriginalPositionTiLiShuZiText;
        }
    }
    public GameObject JinBiShuZiText
    {
        get
        {
            if (jinBiShuZiText == null)
            {
                jinBiShuZiText = this.transform.Find("JinBiShuZiText").gameObject;
                uiOriginalPositionJinBiShuZiText = jinBiShuZiText.transform.localPosition;
            }
            return jinBiShuZiText;
        }
    }
    public Vector3 UIOriginalPositionJinBiShuZiText
    {
        get
        {
            if (jinBiShuZiText == null)
            {
                return JinBiShuZiText.transform.localPosition;
            }
            return uiOriginalPositionJinBiShuZiText;
        }
    }
    public GameObject ZuanShiShuZiText
    {
        get
        {
            if (zuanShiShuZiText == null)
            {
                zuanShiShuZiText = this.transform.Find("ZuanShiShuZiText").gameObject;
                uiOriginalPositionZuanShiShuZiText = zuanShiShuZiText.transform.localPosition;
            }
            return zuanShiShuZiText;
        }
    }
    public Vector3 UIOriginalPositionZuanShiShuZiText
    {
        get
        {
            if (zuanShiShuZiText == null)
            {
                return ZuanShiShuZiText.transform.localPosition;
            }
            return uiOriginalPositionZuanShiShuZiText;
        }
    }
}
