using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public partial class ContainerLoginxuanrenUIController : UIControllerBase
{
    #region --变量定义
    private ToggleGroup roleSelectToggleGroup;

    #endregion

    #region --系统函数
    private void Start()
    {
        Init();
    }
    #endregion

    #region --自定义函数
    private void Init()
    {
        //设置点击进入游戏按钮动画
        Sequence _sequence = DOTween.Sequence();
        _sequence.Append(this.PressEnterButton.transform.DOScale(new Vector3(0.75f, 0.75f, 0.75f), 1f).SetEase(Ease.Linear));
        _sequence.Append(this.PressEnterButton.transform.DOScale(new Vector3(1f, 1f, 1f), 1f).SetEase(Ease.OutElastic));
        _sequence.SetLoops(-1);
    }
    private void InitUIEvent()
    { }
    #endregion
}
