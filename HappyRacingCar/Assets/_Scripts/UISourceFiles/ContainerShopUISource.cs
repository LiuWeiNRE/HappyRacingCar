/* UISource File Create Data: 11/3/2019 12:30:58 PM*/

using UnityEngine;

public partial class ContainerShopUIController : UIControllerBase
{
    private GameObject backGround;
    private Vector3 uiOriginalPositionBackGround;
    private GameObject toggle1TiLi;
    private Vector3 uiOriginalPositionToggle1TiLi;
    private GameObject toggle2ZuanShi;
    private Vector3 uiOriginalPositionToggle2ZuanShi;
    private GameObject toggle3Jinbi;
    private Vector3 uiOriginalPositionToggle3Jinbi;
    private GameObject toggle4DaoJu;
    private Vector3 uiOriginalPositionToggle4DaoJu;
    private GameObject backButton;
    private Vector3 uiOriginalPositionBackButton;
    private GameObject jiaHaoTiLiButton;
    private Vector3 uiOriginalPositionJiaHaoTiLiButton;
    private GameObject jiaHaoZuanShiButton;
    private Vector3 uiOriginalPositionJiaHaoZuanShiButton;
    private GameObject jiaHaoJinBiButton;
    private Vector3 uiOriginalPositionJiaHaoJinBiButton;
    private GameObject touXiangButton;
    private Vector3 uiOriginalPositionTouXiangButton;
    private GameObject mingZiText;
    private Vector3 uiOriginalPositionMingZiText;
    private GameObject tiLiShuZiText;
    private Vector3 uiOriginalPositionTiLiShuZiText;
    private GameObject jinBiShuZiText;
    private Vector3 uiOriginalPositionJinBiShuZiText;
    private GameObject zuanShiShuZiText;
    private Vector3 uiOriginalPositionZuanShiShuZiText;
    private GameObject tiLiScrollView;
    private Vector3 uiOriginalPositionTiLiScrollView;
    private GameObject zuanShiScrollView;
    private Vector3 uiOriginalPositionZuanShiScrollView;
    private GameObject jinBiScrollView;
    private Vector3 uiOriginalPositionJinBiScrollView;
    private GameObject daoJuScrollView;
    private Vector3 uiOriginalPositionDaoJuScrollView;


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
    public GameObject Toggle1TiLi
    {
        get
        {
            if (toggle1TiLi == null)
            {
                toggle1TiLi = this.transform.Find("Toggle1TiLi").gameObject;
                uiOriginalPositionToggle1TiLi = toggle1TiLi.transform.localPosition;
            }
            return toggle1TiLi;
        }
    }
    public Vector3 UIOriginalPositionToggle1TiLi
    {
        get
        {
            if (toggle1TiLi == null)
            {
                return Toggle1TiLi.transform.localPosition;
            }
            return uiOriginalPositionToggle1TiLi;
        }
    }
    public GameObject Toggle2ZuanShi
    {
        get
        {
            if (toggle2ZuanShi == null)
            {
                toggle2ZuanShi = this.transform.Find("Toggle2ZuanShi").gameObject;
                uiOriginalPositionToggle2ZuanShi = toggle2ZuanShi.transform.localPosition;
            }
            return toggle2ZuanShi;
        }
    }
    public Vector3 UIOriginalPositionToggle2ZuanShi
    {
        get
        {
            if (toggle2ZuanShi == null)
            {
                return Toggle2ZuanShi.transform.localPosition;
            }
            return uiOriginalPositionToggle2ZuanShi;
        }
    }
    public GameObject Toggle3Jinbi
    {
        get
        {
            if (toggle3Jinbi == null)
            {
                toggle3Jinbi = this.transform.Find("Toggle3Jinbi").gameObject;
                uiOriginalPositionToggle3Jinbi = toggle3Jinbi.transform.localPosition;
            }
            return toggle3Jinbi;
        }
    }
    public Vector3 UIOriginalPositionToggle3Jinbi
    {
        get
        {
            if (toggle3Jinbi == null)
            {
                return Toggle3Jinbi.transform.localPosition;
            }
            return uiOriginalPositionToggle3Jinbi;
        }
    }
    public GameObject Toggle4DaoJu
    {
        get
        {
            if (toggle4DaoJu == null)
            {
                toggle4DaoJu = this.transform.Find("Toggle4DaoJu").gameObject;
                uiOriginalPositionToggle4DaoJu = toggle4DaoJu.transform.localPosition;
            }
            return toggle4DaoJu;
        }
    }
    public Vector3 UIOriginalPositionToggle4DaoJu
    {
        get
        {
            if (toggle4DaoJu == null)
            {
                return Toggle4DaoJu.transform.localPosition;
            }
            return uiOriginalPositionToggle4DaoJu;
        }
    }
    public GameObject BackButton
    {
        get
        {
            if (backButton == null)
            {
                backButton = this.transform.Find("BackButton").gameObject;
                uiOriginalPositionBackButton = backButton.transform.localPosition;
            }
            return backButton;
        }
    }
    public Vector3 UIOriginalPositionBackButton
    {
        get
        {
            if (backButton == null)
            {
                return BackButton.transform.localPosition;
            }
            return uiOriginalPositionBackButton;
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
    public GameObject TouXiangButton
    {
        get
        {
            if (touXiangButton == null)
            {
                touXiangButton = this.transform.Find("TouXiangButton").gameObject;
                uiOriginalPositionTouXiangButton = touXiangButton.transform.localPosition;
            }
            return touXiangButton;
        }
    }
    public Vector3 UIOriginalPositionTouXiangButton
    {
        get
        {
            if (touXiangButton == null)
            {
                return TouXiangButton.transform.localPosition;
            }
            return uiOriginalPositionTouXiangButton;
        }
    }
    public GameObject MingZiText
    {
        get
        {
            if (mingZiText == null)
            {
                mingZiText = this.transform.Find("MingZiText").gameObject;
                uiOriginalPositionMingZiText = mingZiText.transform.localPosition;
            }
            return mingZiText;
        }
    }
    public Vector3 UIOriginalPositionMingZiText
    {
        get
        {
            if (mingZiText == null)
            {
                return MingZiText.transform.localPosition;
            }
            return uiOriginalPositionMingZiText;
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
    public GameObject TiLiScrollView
    {
        get
        {
            if (tiLiScrollView == null)
            {
                tiLiScrollView = this.transform.Find("TiLiScrollView").gameObject;
                uiOriginalPositionTiLiScrollView = tiLiScrollView.transform.localPosition;
            }
            return tiLiScrollView;
        }
    }
    public Vector3 UIOriginalPositionTiLiScrollView
    {
        get
        {
            if (tiLiScrollView == null)
            {
                return TiLiScrollView.transform.localPosition;
            }
            return uiOriginalPositionTiLiScrollView;
        }
    }
    public GameObject ZuanShiScrollView
    {
        get
        {
            if (zuanShiScrollView == null)
            {
                zuanShiScrollView = this.transform.Find("ZuanShiScrollView").gameObject;
                uiOriginalPositionZuanShiScrollView = zuanShiScrollView.transform.localPosition;
            }
            return zuanShiScrollView;
        }
    }
    public Vector3 UIOriginalPositionZuanShiScrollView
    {
        get
        {
            if (zuanShiScrollView == null)
            {
                return ZuanShiScrollView.transform.localPosition;
            }
            return uiOriginalPositionZuanShiScrollView;
        }
    }
    public GameObject JinBiScrollView
    {
        get
        {
            if (jinBiScrollView == null)
            {
                jinBiScrollView = this.transform.Find("JinBiScrollView").gameObject;
                uiOriginalPositionJinBiScrollView = jinBiScrollView.transform.localPosition;
            }
            return jinBiScrollView;
        }
    }
    public Vector3 UIOriginalPositionJinBiScrollView
    {
        get
        {
            if (jinBiScrollView == null)
            {
                return JinBiScrollView.transform.localPosition;
            }
            return uiOriginalPositionJinBiScrollView;
        }
    }
    public GameObject DaoJuScrollView
    {
        get
        {
            if (daoJuScrollView == null)
            {
                daoJuScrollView = this.transform.Find("DaoJuScrollView").gameObject;
                uiOriginalPositionDaoJuScrollView = daoJuScrollView.transform.localPosition;
            }
            return daoJuScrollView;
        }
    }
    public Vector3 UIOriginalPositionDaoJuScrollView
    {
        get
        {
            if (daoJuScrollView == null)
            {
                return DaoJuScrollView.transform.localPosition;
            }
            return uiOriginalPositionDaoJuScrollView;
        }
    }
}
