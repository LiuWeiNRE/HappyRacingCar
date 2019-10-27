using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public partial class ContainerTankuangUIController : UIControllerBase
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
        //窗口弹出动画
        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(Vector3.one, 0.25f).SetEase(Ease.OutBack);

        //关闭按钮动画
        Sequence _sequence = DOTween.Sequence();
        _sequence.Append(this.CloseButton.transform.DOScale(new Vector3(0.65f, 0.65f, 0.65f), 1f).SetEase(Ease.Linear));
        _sequence.Append(this.CloseButton.transform.DOScale(Vector3.one, 1f).SetEase(Ease.OutElastic));
        _sequence.SetLoops(-1);
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
    #endregion
}
