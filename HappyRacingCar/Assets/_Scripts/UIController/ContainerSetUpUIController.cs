using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public partial class ContainerSetUpUIController : UIControllerBase 
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
        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(Vector3.one, 0.25f).SetEase(Ease.OutBack);

        CanvasGroup _canvasGroup = this.GetComponent<CanvasGroup>();
        DOVirtual.Float(0.0f, 1, 0.25f, delegate (float _value)
           {
               _canvasGroup.alpha = _value;
           }).SetEase(Ease.Linear).SetUpdate(true);
    }
    private void InitUIEvent()
    {
        this.CloseButton.GetComponent<Button>().onClick.AddListener(CloseButtonOnClick);
        this.MusicONButton.GetComponent<Button>().onClick.AddListener(MusicONButtonOnClick);
        this.MusicOFFButton.GetComponent<Button>().onClick.AddListener(MusicOFFButtonOnClick);
        this.MusicEffectONButton.GetComponent<Button>().onClick.AddListener(MusicEffectONButtonOnClick);
        this.MusicEffectOFFButton.GetComponent<Button>().onClick.AddListener(MusicEffectOFFButtonOnClick);
        
        //TODO

        //关闭按钮特效
        Sequence _mySeq = DOTween.Sequence();
        _mySeq.Append(this.CloseButton.transform.DOScale(new Vector3(0.9f, 0.9f, 0.9f), 1).SetEase(Ease.Linear));
        _mySeq.Append(this.CloseButton.transform.DOScale(Vector3.one, 1).SetEase(Ease.OutElastic));
        _mySeq.SetLoops(-1);
    }

    private void MusicONButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
        this.MusicONButton.SetActive(false);
        this.MusicOFFButton.SetActive(true);

        SoundManager.BGSoundGroup.Mute = true;

        //TODO
    }
    private void MusicOFFButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
        this.MusicONButton.SetActive(true);
        this.MusicOFFButton.SetActive(false);

        SoundManager.BGSoundGroup.Mute = false;
        //TODO
    }
    private void MusicEffectONButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
        this.MusicEffectONButton.SetActive(false);
        this.MusicEffectOFFButton.SetActive(true);

        SoundManager.EffectSoundGroup.Mute = true;
        //TODO
    }
    private void MusicEffectOFFButtonOnClick()
    {
        SoundManager.EffectSoundGroup.Play("SoundResources/dakaianniu");
        this.MusicEffectONButton.SetActive(true);
        this.MusicEffectOFFButton.SetActive(false);

        SoundManager.EffectSoundGroup.Mute = false;
        //TODO
    }
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
