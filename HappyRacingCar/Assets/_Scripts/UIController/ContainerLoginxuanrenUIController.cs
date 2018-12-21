using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;

public partial class ContainerLoginxuanrenUIController : UIControllerBase
{
    #region --变量定义
    /// <summary>
    /// 角色选择结果。默认为第一个何炅。
    /// </summary>
    [HideInInspector] public int roleResult = 1;
    /// <summary>
    /// 性别选择结果。默认为男孩boy。
    /// </summary>
    [HideInInspector] public string sexResult = "boy";

    private ToggleGroup roleSelectToggleGroup;//角色选择ToggleGroup组
    private ToggleGroup sexSelectToggleGroup;//性别选择ToggleGroup组
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
        //获取组件
        roleSelectToggleGroup = this.BackGround.GetComponent<ToggleGroup>();
        sexSelectToggleGroup = this.SexBoyToggle.GetComponent<ToggleGroup>();

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
        _sequence3.Append(_selectStateImage.DOScale(new Vector3(1.06f, 1.06f, 1f), 0.5f).SetEase(Ease.Linear));
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
    {
        //给选人Toggle添加事件
        this.HeJiongToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectRoleToggleOnChange);
        this.XieNaToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectRoleToggleOnChange);
        this.WuXinToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectRoleToggleOnChange);
        this.WeiJiaToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectRoleToggleOnChange);
        this.DuHaiTaoToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectRoleToggleOnChange);

        //给选性别Toggle添加事件
        this.SexBoyToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectSexToggleOnChange);
        this.SexGirlToggle.GetComponent<Toggle>().onValueChanged.AddListener(SelectSexToggleOnChange);
    }

    /// <summary>
    /// 选人Toggle点击事件
    /// </summary>
    /// <param name="_value"></param>
    private void SelectRoleToggleOnChange(bool _value)
    {
        if (!_value)
        {
            return;
        }
        IEnumerable<Toggle> _toggles = roleSelectToggleGroup.ActiveToggles();
        foreach (Toggle item in _toggles)
        {
            if (item.gameObject.name.Equals(this.HeJiongToggle.name))
            {
                roleResult = 1;
            }
            else if (item.gameObject.name.Equals(this.XieNaToggle.name))
            {
                roleResult = 2;
            }
            else if (item.gameObject.name.Equals(this.WuXinToggle.name))
            {
                roleResult = 3;
            }
            else if (item.gameObject.name.Equals(this.WeiJiaToggle.name))
            {
                roleResult = 4;
            }
            else if (item.gameObject.name.Equals(this.DuHaiTaoToggle.name))
            {
                roleResult = 5;
            }
        }
    }
    /// <summary>
    /// 选性别Toggle点击事件
    /// </summary>
    /// <param name="_value"></param>
    private void SelectSexToggleOnChange(bool _value)
    {
        if (!_value)
        {
            return;
        }
        IEnumerable<Toggle> _toggles = sexSelectToggleGroup.ActiveToggles();
        foreach (Toggle item in _toggles)
        {
            if (item.gameObject.name.Equals(this.SexBoyToggle.name))
            {
                sexResult = "Boy";
            }
            else if (item.gameObject.name.Equals(this.SexGirlToggle.name))
            {
                sexResult = "Girl";
            }
        }
    }
    #endregion
}
