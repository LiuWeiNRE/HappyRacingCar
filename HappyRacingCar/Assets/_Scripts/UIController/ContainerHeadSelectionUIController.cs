using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public partial class ContainerHeadSelectionUIController : UIControllerBase
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
        //界面弹出动画
        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(Vector3.one, 0.25f).SetUpdate(true).SetEase(Ease.OutBack);
    }
    private void InitUIEvent()
    {
        this.CloseButton.GetComponent<Button>().onClick.AddListener(CloseButtonOnClick);

        //给所有的头像按钮添加事件
        Transform _content = this.HeadList.transform.Find("Viewport/Content");
        foreach (Transform item in _content)
        {
            item.GetComponent<Button>().onClick.AddListener(AllHeadButtonOnClick);
        }
    }

    /// <summary>
    /// 关闭按钮响应事件
    /// </summary>
    private void CloseButtonOnClick()
    {
        ClosePanel();
        SoundManager.EffectSoundGroup.Play("SoundResources/Close");
    }
    /// <summary>
    /// 所有头像按钮响应事件
    /// </summary>
    private void AllHeadButtonOnClick()
    {
        GameObject _pressedHeadButton = EventSystem.current.currentSelectedGameObject;
        Sprite _headSprite = _pressedHeadButton.GetComponentsInChildren<Image>()[1].sprite;
        //暂未更新数据
        Debug.Log(_headSprite.name);
        SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
        ClosePanel();
    }
    /// <summary>
    /// 关闭界面。
    /// </summary>
    private void ClosePanel()
    {
        this.MaskBackGround.SetActive(false);
        this.transform.DOScale(Vector3.zero, 0.25f).OnComplete(delegate ()
        {
            this.Close();
        }).SetUpdate(true).SetEase(Ease.InBack);
    }
    #endregion
}
