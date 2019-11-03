using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public partial class ContainerMeiRiLogInUIController : UIControllerBase
{
    #region --变量定义
    private GameObject[] daysGameObjects = new GameObject[7]; //每日奖励游戏物体数组，共7个
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
        SoundManager.EffectSoundGroup.Play("SoundResources/queren");
        this.MaskBackGround.SetActive(false);
        this.transform.DOScale(Vector3.zero, 0.25f).OnComplete(delegate ()
        {
            this.Close();
        }).SetEase(Ease.InBack);
    }
    /// <summary>
    /// 初始化每日奖励游戏物体数组
    /// </summary>
    private void InitDaysGameObjects()
    {
        //将每日奖励的游戏添加到 daysGameObjects 数组中
        daysGameObjects[0] = this.FirstDayPrize;
        daysGameObjects[1] = this.SecondDayPrize;
        daysGameObjects[2] = this.ThirdDayPrize;
        daysGameObjects[3] = this.FourthDayPrize;
        daysGameObjects[4] = this.FifthDayPrize;
        daysGameObjects[5] = this.SixthDayPrize;
        daysGameObjects[6] = this.SeventhDayPrize;
    }

    /// <summary>
    /// 根据第几天设置每日奖励相关UI操作
    /// </summary>
    /// <param name="_day">第几天</param>
    public void SetDailyRewards(int _day)
    {
        if (_day <= 0 || _day > 7)
        {
            Debug.LogError("Please check this code,valid value is [1~7],but param is " + _day);
            return;
        }

        InitDaysGameObjects();
        GameObject _current = daysGameObjects[_day - 1];

        GameObject _todayBg = _current.transform.Find("TodayBg").gameObject;
        if (_todayBg != null)
        {
            _todayBg.SetActive(true);
        }

        Transform _haveReceivedImage = _current.transform.Find("HaveReceivedImage");
        if (_haveReceivedImage != null)
        {
            _haveReceivedImage.gameObject.SetActive(true);
            _haveReceivedImage.localScale = Vector3.zero;
            DOVirtual.DelayedCall(0.5f, delegate ()
            {
                _haveReceivedImage.localScale = new Vector3(5, 5, 5);
                _haveReceivedImage.DOScale(Vector3.one, 0.85f).SetEase(Ease.OutBounce).SetUpdate(true).OnComplete(delegate ()
                {
                    _haveReceivedImage.DOScale(0.85f, 1.0f).SetLoops(-1, LoopType.Yoyo);
                });
            }, true);
        }
    }
    #endregion
}
