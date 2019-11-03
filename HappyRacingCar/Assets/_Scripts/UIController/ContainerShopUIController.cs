using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class ContainerShopUIController : UIControllerBase
{
    #region --变量定义
    private static ContainerShopUIController instance;
    private static ShopType shopType = ShopType.ShopDiamond;
    private static GameObject currentShop = null;

    //显示用户已有道具数量的Text
    private Text countFeidanText = null;
    private Text countHudunText = null;
    private Text countYinshenText = null;
    private Text countJiasuText = null;

    //钻石商城中，显示购买物品赠送积分数量的Text
    private Text givingScore1Text = null;
    private Text givingScore2Text = null;
    private Text givingScore3Text = null;
    private Text givingScore4Text = null;

    private ToggleGroup shopTypeToggleGroup;
    #endregion

    #region --系统函数
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Init();
        InitUIEvent();
    }
    #endregion

    #region --自定义函数
    public static ShopType CurrentShopType
    {
        get { return shopType; }
        set
        {
            if (shopType == value)
            {
                return;
            }

            shopType = value;
            if (currentShop != null)
            {
                currentShop.SetActive(false);
            }
            else
            {
                ContainerShopUIController.instance.TiLiScrollView.SetActive(false);
                ContainerShopUIController.instance.ZuanShiScrollView.SetActive(false);
                ContainerShopUIController.instance.JinBiScrollView.SetActive(false);
                ContainerShopUIController.instance.DaoJuScrollView.SetActive(false);
            }
            switch (shopType)
            {
                case ShopType.ShopPower:
                    currentShop = ContainerShopUIController.instance.TiLiScrollView;
                    break;
                case ShopType.ShopDiamond:
                    currentShop = ContainerShopUIController.instance.ZuanShiScrollView;
                    break;
                case ShopType.ShopCoin:
                    currentShop = ContainerShopUIController.instance.JinBiScrollView;
                    break;
                case ShopType.ShopProps:
                    currentShop = ContainerShopUIController.instance.DaoJuScrollView;
                    break;
                case ShopType.ShopScore:
                    Debug.LogError("积分商城，未开放！");
                    break;
                default:
                    currentShop = ContainerShopUIController.instance.TiLiScrollView;
                    break;
            }
            currentShop.SetActive(true);
        }
    }

    private void Init()
    {
        shopTypeToggleGroup = this.GetComponent<ToggleGroup>();

        givingScore1Text = this.ZuanShiScrollView.transform.Find("Viewport/Content/X100/JFSZText").GetComponent<Text>();
        givingScore2Text = this.ZuanShiScrollView.transform.Find("Viewport/Content/X500/JFSZText").GetComponent<Text>();
        givingScore3Text = this.ZuanShiScrollView.transform.Find("Viewport/Content/X1000/JFSZText").GetComponent<Text>();
        givingScore4Text = this.ZuanShiScrollView.transform.Find("Viewport/Content/X5000/JFSZText").GetComponent<Text>();

        countFeidanText = this.DaoJuScrollView.transform.Find("Viewport/Content/X100/YiYouShuZiText").GetComponent<Text>();
        countHudunText = this.DaoJuScrollView.transform.Find("Viewport/Content/X500/YiYouShuZiText").GetComponent<Text>();
        countYinshenText = this.DaoJuScrollView.transform.Find("Viewport/Content/X1000/YiYouShuZiText").GetComponent<Text>();
        countJiasuText = this.DaoJuScrollView.transform.Find("Viewport/Content/X5000/YiYouShuZiText").GetComponent<Text>();

        InitShopData();
        InitTopToggle();
    }
    private void InitUIEvent()
    {
        this.TouXiangButton.GetComponent<Button>().onClick.AddListener(TouXiangButtonOnClick);
        this.JiaHaoTiLiButton.GetComponent<Button>().onClick.AddListener(JiaHaoTiLiButtonOnClick);
        this.JiaHaoZuanShiButton.GetComponent<Button>().onClick.AddListener(JiaHaoZuanShiButtonOnClick);
        this.JiaHaoJinBiButton.GetComponent<Button>().onClick.AddListener(JiaHaoJinBiButtonOnClick);
        this.BackButton.GetComponent<Button>().onClick.AddListener(BackButtonOnClick);

        this.Toggle1TiLi.GetComponent<Toggle>().onValueChanged.AddListener(AllToggleOnValueChanged);
        this.Toggle2ZuanShi.GetComponent<Toggle>().onValueChanged.AddListener(AllToggleOnValueChanged);
        this.Toggle3Jinbi.GetComponent<Toggle>().onValueChanged.AddListener(AllToggleOnValueChanged);
        this.Toggle4DaoJu.GetComponent<Toggle>().onValueChanged.AddListener(AllToggleOnValueChanged);
    }
    /// <summary>
    /// 初始化商城信息
    /// </summary>
    private void InitShopData()
    {
        //1、TODO：获取商城配置信息
        //2、TODO：更加配置信息初始化UI界面。包括已有的金币、钻石、体力的数量，钻石商城购买物品所送积分信息，用户已有的各种道具数量。
    }
    /// <summary>
    /// 初始化顶部的体力、钻石、金币、道具Toggle.
    /// </summary>
    private void InitTopToggle()
    {
        switch (CurrentShopType)
        {
            case ShopType.ShopPower:
                this.Toggle1TiLi.GetComponent<Toggle>().isOn = true;
                break;
            case ShopType.ShopDiamond:
                this.Toggle2ZuanShi.GetComponent<Toggle>().isOn = true;
                break;
            case ShopType.ShopCoin:
                this.Toggle3Jinbi.GetComponent<Toggle>().isOn = true;
                break;
            case ShopType.ShopProps:
                this.Toggle4DaoJu.GetComponent<Toggle>().isOn = true;
                break;
            case ShopType.ShopScore:
                break;
            default:
                this.Toggle1TiLi.GetComponent<Toggle>().isOn = true;
                break;
        }
    }

    private void TouXiangButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
        PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.PopupWindow, UIControllerConst.UI_PREFEB_HEAD_SELECTION);
    }
    private void JiaHaoTiLiButtonOnClick()
    {
        this.Toggle1TiLi.GetComponent<Toggle>().isOn = true;
        CurrentShopType = ShopType.ShopPower;
    }
    private void JiaHaoZuanShiButtonOnClick()
    {
        this.Toggle2ZuanShi.GetComponent<Toggle>().isOn = true;
        CurrentShopType = ShopType.ShopDiamond;
    }
    private void JiaHaoJinBiButtonOnClick()
    {
        this.Toggle3Jinbi.GetComponent<Toggle>().isOn = true;
        CurrentShopType = ShopType.ShopCoin;
    }
    private void BackButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/Close");
        this.transform.DOScale(Vector3.zero, 0.25f).OnComplete(delegate ()
         {
             //TODO
             this.Close();
         }).SetUpdate(true);
    }
    /// <summary>
    /// 切换商城类型的Toggle响应事件
    /// </summary>
    /// <param name="_value"></param>
    private void AllToggleOnValueChanged(bool _value)
    {
        if (_value)
        {
            SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
            IEnumerable<Toggle> _toggles = shopTypeToggleGroup.ActiveToggles();
            foreach (Toggle item in _toggles)
            {
                if (item.name.Equals(this.Toggle1TiLi.name))
                {
                    CurrentShopType = ShopType.ShopPower;
                }
                else if (item.name.Equals(this.Toggle2ZuanShi.name))
                {
                    CurrentShopType = ShopType.ShopDiamond;
                }
                else if (item.name.Equals(this.Toggle3Jinbi.name))
                {
                    CurrentShopType = ShopType.ShopCoin;
                }
                else if (item.name.Equals(this.Toggle4DaoJu.name))
                {
                    CurrentShopType = ShopType.ShopProps;
                }
                else
                {
                    Debug.LogError("未知的商城类型Toggle组件，请排查！");
                }
            }
        }
    }
    #endregion

    public enum ShopType
    {
        ShopPower = 1,//体力
        ShopDiamond = 2,//钻石
        ShopCoin = 3,//金币
        ShopProps = 4,//道具
        ShopScore = 5,//积分
    }
}