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
        //设置默认人物和性别
        this.HeJiongToggle.GetComponent<Toggle>().isOn = true;
        this.SexBoyToggle.GetComponent<Toggle>().isOn = true;

        //设置点击进入游戏按钮动画
        Sequence _sequence1 = DOTween.Sequence();
        _sequence1.Append(this.PressEnterButton.transform.DOScale(new Vector3(0.75f, 0.75f, 0.75f), 1f).SetEase(Ease.Linear));
        _sequence1.Append(this.PressEnterButton.transform.DOScale(new Vector3(1f, 1f, 1f), 1f).SetEase(Ease.OutElastic));
        _sequence1.SetLoops(-1);

        //设置错误提示框的动画
        Sequence _sequence2 = DOTween.Sequence();
        _sequence2.Append(this.HintText.transform.DOScale(new Vector3(0.85f, 0.85f, 0.85f), 1f).SetEase(Ease.Linear));
        _sequence2.Append(this.HintText.transform.DOScale(new Vector3(1f, 1f, 1f), 1f).SetEase(Ease.Linear));
        _sequence2.SetLoops(-1);

        //设置所有选人按钮动画
        Sequence _sequence3 = DOTween.Sequence();
        Transform _selectStateImage = this.HeJiongToggle.transform.Find("SelectStateImage");
        _sequence3.Append(_selectStateImage.DOScale(new Vector3(1.06f,1.06f,1f), 0.5f).SetEase(Ease.Linear));
        _sequence3.Append(_selectStateImage.DOScale(new Vector3(0.98f, 0.98f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence3.SetLoops(-1);
        Sequence _sequence4 = DOTween.Sequence();
        _selectStateImage = this.XieNaToggle.transform.Find("SelectStateImage");
        _sequence4.Append(_selectStateImage.DOScale(new Vector3(1.06f, 1.06f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence4.Append(_selectStateImage.DOScale(new Vector3(0.98f, 0.98f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence4.SetLoops(-1);
        Sequence _sequence5 = DOTween.Sequence();
        _selectStateImage = this.WuXinToggle.transform.Find("SelectStateImage");
        _sequence5.Append(_selectStateImage.DOScale(new Vector3(1.06f, 1.06f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence5.Append(_selectStateImage.DOScale(new Vector3(0.98f, 0.98f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence5.SetLoops(-1);
        Sequence _sequence6 = DOTween.Sequence();
        _selectStateImage = this.WeiJiaToggle.transform.Find("SelectStateImage");
        _sequence6.Append(_selectStateImage.DOScale(new Vector3(1.06f, 1.06f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence6.Append(_selectStateImage.DOScale(new Vector3(0.98f, 0.98f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence6.SetLoops(-1);
        Sequence _sequence7 = DOTween.Sequence();
        _selectStateImage = this.DuHaiTaoToggle.transform.Find("SelectStateImage");
        _sequence7.Append(_selectStateImage.DOScale(new Vector3(1.06f, 1.06f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence7.Append(_selectStateImage.DOScale(new Vector3(0.98f, 0.98f, 1f), 0.5f).SetEase(Ease.Linear));
        _sequence7.SetLoops(-1);

    }
    private void InitUIEvent()
    { }
    #endregion
}
