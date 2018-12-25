using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public partial class ContainerMeiRiLogInUIController : UIControllerBase 
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
        //给OK按钮添加动画，并使其不受Time.timeScale影响
        this.OKButton.transform.DOScale(0.9f, 1.0f).SetUpdate(true).SetLoops(-1, LoopType.Yoyo);
    }
    private void InitUIEvent()
    {
        this.OKButton.GetComponent<Button>().onClick.AddListener(OKButtonOnClick);

        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(Vector3.one, 0.5f).SetUpdate(true).SetEase(Ease.OutBack);
    }

    private void OKButtonOnClick()
    {
        this.MaskBackGround.SetActive(false);
        this.transform.DOScale(Vector3.zero, 0.25f).OnComplete(delegate () {
            this.Close();
        }).SetEase(Ease.InBack);
    }
    #endregion
}
