/*
 * 工具组件 —— 帧动画
 */
using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Image))]
public class FrameAnimation : MonoBehaviour
{
    #region --变量定义
    /// <summary>
    /// 动画图片数组
    /// </summary>
    public Sprite[] sprites;
    /// <summary>
    /// 加载时是否播放
    /// </summary>
    public bool playOnAwake;
    /// <summary>
    /// 间隔时间
    /// </summary>
    [Range(0, 1)]
    public float intervalTime = 0.2f;
    /// <summary>
    /// 是否循环
    /// </summary>
    public bool loop;

    private Image mImage;
    private bool mIsPlaying;//是否正在播放
    private float mPlayTime;//动画播放时间
    private Action endAction;//动画播放结束时响应事件，只适用于单次播放。
    #endregion

    #region --系统函数
    private void Start()
    {
        this.Init();
        if (this.playOnAwake)
        {
            if (loop)
            {
                this.PlayLoop();
            }
            else
            {
                this.PlayOnce();
            }
        }
    }
    private void Update()
    {
        this.ChangeSprite();
    }
    #endregion

    #region --自定义函数
    private void Init()
    {
        this.mImage = this.GetComponent<Image>();
    }
    /// <summary>
    /// 是否正在播放
    /// </summary>
    public bool IsPlaying
    {
        get
        {
            return this.mIsPlaying;
        }
    }
    /// <summary>
    /// 播放一次
    /// </summary>
    public void PlayOnce()
    {
        if (this.sprites == null)
        {
            Debug.LogError("动画图片数组 sprites 为空，无法播放动画");
            return;
        }
        this.mPlayTime = 0;
        this.loop = false;
        this.mIsPlaying = true;
    }
    /// <summary>
    /// 播放一次
    /// </summary>
    /// <param name="_endAction">动画结束时调用该事件</param>
    public void PlayOnce(Action _endAction)
    {
        if (this.sprites == null)
        {
            Debug.LogError("动画图片数组 sprites 为空，无法播放动画");
            return;
        }
        this.mPlayTime = 0;
        this.loop = false;
        this.mIsPlaying = true;
        this.endAction = _endAction;
    }
    /// <summary>
    /// 循环播放
    /// </summary>
    public void PlayLoop()
    {
        if (this.sprites == null)
        {
            Debug.LogError("动画图片数组 sprites 为空，无法播放动画");
            return;
        }
        this.mPlayTime = 0;
        this.mIsPlaying = true;
        this.loop = true;
    }
    /// <summary>
    /// 停止播放
    /// </summary>
    public void Stop()
    {
        this.mIsPlaying = false;
    }
    /// <summary>
    /// 切换图片
    /// </summary>
    private void ChangeSprite()
    {
        if (this.mIsPlaying == false)
        {
            return;
        }
        if (this.sprites.Length > 1)
        {
            this.mPlayTime += Time.deltaTime;
            int _index = (int)(this.mPlayTime / this.intervalTime);
            if (this.loop)
            {
                _index %= this.sprites.Length;
                this.mImage.sprite = sprites[_index];
            }
            else
            {
                if (_index < this.sprites.Length)
                {
                    this.mImage.sprite = sprites[_index];
                }
                else
                {
                    if (endAction != null)
                    {
                        endAction();
                    }
                    this.Stop();
                }
            }
        }
    }
    #endregion
}
