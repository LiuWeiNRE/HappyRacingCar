/* 登陆界面UI控制。
 * 1、平台登陆按钮和切换账号按钮只能显示一个。
 * 2、开始游戏
 */

using UnityEngine;
using UnityEngine.UI;

public partial class ContainerLogindengluUIController : UIControllerBase
{
    #region --变量定义
    private bool boolPlatformLoginButton = false;//平台登陆按钮是否显示
    #endregion

    #region --系统函数
    private void Start()
    {
        this.ButtonQiehuanzhanghao.GetComponent<Button>().onClick.AddListener(QieHuanZhangHaoButtonOnClick);
        this.ButtonPingtaidenglu.GetComponent<Button>().onClick.AddListener(PingTaiDengLuButtonOnClick);
        this.ButtonKaishiyouxi.GetComponent<Button>().onClick.AddListener(KaiShiYouXiButtonOnClick);

        SoundManager.Play("SoundResources/Login", true, "bg");
    }
    #endregion

    #region --自定义函数
    private void QieHuanZhangHaoButtonOnClick()
    {
        boolPlatformLoginButton = true;
        SwitchPlatformLoginOrChangeNumber(boolPlatformLoginButton);
        SoundManager.EffectSoundGroup.Play("SoundResources/moshixuanze");
    }
    private void PingTaiDengLuButtonOnClick()
    {
        boolPlatformLoginButton = false;
        SwitchPlatformLoginOrChangeNumber(boolPlatformLoginButton);
        SoundManager.EffectSoundGroup.Play("SoundResources/moshixuanze");
    }
    private void KaiShiYouXiButtonOnClick()
    {
        Debug.Log("开始游戏！");
        PanelMainUIController.Instance.CleanAllUI();
        PanelMainUIController.Instance.AddUIPanel(PanelMainUIController.UILayer.Bottom, "ContainerLoginxuanren");
        SoundManager.EffectSoundGroup.Play("SoundResources/moshixuanze");
    }

    /// <summary>
    /// 平台登陆按钮和切换账号按钮只能显示其中一个。
    /// </summary>
    /// <param name="_boolPlatformLoginButton"></param>
    private void SwitchPlatformLoginOrChangeNumber(bool _boolPlatformLoginButton)
    {
        if (_boolPlatformLoginButton)
        {
            this.ButtonPingtaidenglu.SetActive(true);
            this.ButtonQiehuanzhanghao.SetActive(false);
        }
        else
        {
            this.ButtonPingtaidenglu.SetActive(false);
            this.ButtonQiehuanzhanghao.SetActive(true);
        }
    }
    #endregion
}
