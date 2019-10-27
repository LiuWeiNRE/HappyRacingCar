using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public partial class ContainerNoticeUIController : UIControllerBase 
{
    #region --变量定义

    #endregion

    #region --系统函数
    private void Start()
    {
        Init();
        InitUIEvent();
    }
    #endregion

    #region --自定义函数
    private void Init()
    {
        //弹出动画
        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(Vector3.one, 0.25f).SetEase(Ease.OutBack);
    }
    private void InitUIEvent()
    {
        this.CloseButton.GetComponent<Button>().onClick.AddListener(CloseButtonOnClick);
    }

    /// <summary>
    /// 关闭按钮响应事件
    /// </summary>
    private void CloseButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/Close");
        this.MaskBackGround.SetActive(false);
        this.transform.DOScale(Vector3.zero, 0.25f).OnComplete(delegate ()
         {
             this.Close();
         }).SetEase(Ease.InBack);
    }
    /// <summary>
    /// 更新公告板内容
    /// </summary>
    /// <param name="_info">公告板内容</param>
    private void UpdateNoticeInfo(string _info)
    {
        this.NoticeText.GetComponent<Text>().text = _info;
    }
    #endregion
}
