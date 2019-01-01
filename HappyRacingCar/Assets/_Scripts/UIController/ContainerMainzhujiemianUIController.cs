using UnityEngine;
using UnityEngine.UI;

public partial class ContainerMainzhujiemianUIController : UIControllerBase 
{
    #region --变量定义

    #endregion

    #region --系统函数
    private void Start()
    {
        CheckMeiRiLogInUI();
        InitUIEvent();
    }
    #endregion

    #region --自定义函数
    private void InitUIEvent()
    {
        this.HeadPortraitButton.GetComponent<Button>().onClick.AddListener(HeadPortraitButtonOnClick);
        this.GoodFriendButton.GetComponent<Button>().onClick.AddListener(GoodFriendButtonOnClick);
        this.NoticeButton.GetComponent<Button>().onClick.AddListener(NoticeButtonOnClick);
        this.SetUpButton.GetComponent<Button>().onClick.AddListener(SetUpButtonOnClick);
    }

    /// <summary>
    /// 检测每日登陆UI是否显示
    /// </summary>
    private void CheckMeiRiLogInUI()
    {
        //解析我们的excle表格导出的数据信息
        //得到之前已经连续登陆的天数,这个值最好保存到服务器上，然后通过socket 或http通信获得数据。这里暂时放到本地
        //判断当前是第几天登陆
        SetMeiRiLogInData(0);
    }
    /// <summary>
    /// 根据天数发放对应奖励
    /// </summary>
    /// <param name="_day">第几天</param>
    private void SetMeiRiLogInData(int _day)
    {
        //1. 给予奖励,增加金币或者宝石
        //2. 领取次数更新
        //3. 保存数据

        //弹出界面 
        GameObject _containerMeiRiLogIn = PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.PopupWindow, UIControllerConst.UI_PREFEB_MEI_RI_LOGIN);
        //设置 当前是第几天
        _containerMeiRiLogIn.GetComponent<ContainerMeiRiLogInUIController>().SetDailyRewards(1);

    }

    /// <summary>
    /// 头像按钮点击事件
    /// </summary>
    private void HeadPortraitButtonOnClick()
    {
        PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.PopupWindow, UIControllerConst.UI_PREFEB_HEAD_SELECTION);
    }
    /// <summary>
    /// 添加好友按钮点击事件
    /// </summary>
    private void GoodFriendButtonOnClick()
    {
        PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.PopupTip, UIControllerConst.UI_PREFEB_TAN_KUANG);
    }
    /// <summary>
    /// 公告按钮响应事件
    /// </summary>
    private void NoticeButtonOnClick()
    {
        PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.PopupWindow, UIControllerConst.UI_PREFEB_NOTICE);
    }
    /// <summary>
    /// 设置按钮响应事件
    /// </summary>
    private void SetUpButtonOnClick()
    {
        PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.PopupWindow, UIControllerConst.UI_PREFEB_SET_UP);
    }
    #endregion
}
