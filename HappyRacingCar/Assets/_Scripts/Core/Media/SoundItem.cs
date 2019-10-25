using UnityEngine;

/*
 * 一个声音播放通道
 */
public class SoundItem
{
    #region -- 变量定义
    private SoundPlayer soundPlayer;//为当前SoundItem分配的Player对象
    private SoundGroup soundGroup;//SoundItem属于的Group对象
    private float volume = 1;//音量
    private AudioSource audioSource;//声音源对象
    private bool loop = false;//是否循环播放
    private float lastPlayTime;//防止同一个音效，同一时间多次播放
    #endregion

    #region -- 自定义函数
    public SoundItem(int _startTime, bool _loop, SoundPlayer _soundPlayer, GameObject _go)
    {
        lastPlayTime = Time.time;
        this.loop = _loop;
        this.audioSource = _soundPlayer.GetNextAudioSource(_go);
        this.audioSource.loop = loop;
        this.audioSource.Play();
        soundPlayer = _soundPlayer;
        volume = 1;
    }
    public float Volume
    {
        get { return volume; }
        set
        {
            volume = value;
            UpdateVolume();
        }
    }
    public SoundGroup SoundGroup
    {
        get { return soundGroup; }
        set { soundGroup = value; }
    }
    public bool Mute
    {
        get
        {
            if (IsOver())
            {
                return false;
            }
            else
            {
                return audioSource.mute;
            }
        }

        set
        {
            if (IsOver() == false)
            {
                audioSource.mute = value;
            }
        }
    }
    public AudioSource AudioSource
    {
        get { return audioSource; }
    }
    public SoundPlayer SoundPlayer
    {
        get { return soundPlayer; }
    }
    public float LastPlayTime
    {
        get { return lastPlayTime; }
    }
    public bool IsOver()
    {
        return audioSource == null;
    }
    public void UpdateVolume()
    {
        if (audioSource == null)
        {
            return;
        }

        if (soundGroup != null)
        {
            audioSource.volume = volume * soundGroup.Volume;
        }
        else
        {
            audioSource.volume = volume;
        }
    }
    public void Stop()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
    #endregion
}
