using UnityEngine;

/*
 * 一个声音播放通道
 */
public class SoundItem
{
    #region -- 变量定义
    private SoundGroup soundGroup;//SoundItem属于的Group对象
    private AudioSource audioSource;//声音源对象
    #endregion

    #region -- 自定义函数
    internal SoundGroup SoundGroup
    {
        get { return soundGroup; }
        set { soundGroup = value; }
    }
    public AudioSource AudioSource
    {
        get { return audioSource; }
    }
    public bool IsOver()
    {
        return audioSource == null;
    }
    #endregion
}
