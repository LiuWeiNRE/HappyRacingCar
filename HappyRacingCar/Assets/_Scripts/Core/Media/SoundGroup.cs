using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 声音的播放标签，里面包含了同一个标签下的所有声音的播放。
 * 操作播放标签类就可以对里面所有的声音进行统一的管理操作。
 */
public class SoundGroup
{
    #region -- 变量定义
    private float volume = 1;   //音量
    private bool mute = false;  //分组内是否静音

    //分组内播放的声音，是否在声音加载完毕的时候才可以播放。通常背景音乐可以一边加载一边播放。
    private bool loadOverToPlay = false;

    //记录所有的声音单元，注意最小的但是 SoundItem,且 key 和 value 都是 SoundItem 类型。
    private Dictionary<SoundItem, SoundItem> allChannel = new Dictionary<SoundItem, SoundItem>();
    /**
     * 是否启用单通道模式。如果是，则在短时间内，同一个声音只会被播放一次
     * 这里针对的是同一个声音，不同声音不受影响。
     * 0：表示不启用单声道模式。
     * -1：表示当一个声音播放完毕后，才播放另一个声道。
     * >0：表示在指定毫秒内，不再重复播放，推荐100。
     */
    public float singleChangleDuration = 0f;
    private Hashtable singleChangleCatch = new Hashtable();
    #endregion

    #region -- 自定义函数
    public SoundGroup(string _name) { }

    public float Volume
    {
        get { return volume; }
        set
        {
            if (value == volume)
            {
                return;
            }

            value = volume;
            foreach (KeyValuePair<SoundItem, SoundItem> item in allChannel)
            {
                item.Key.UpdateVolume();
            }
        }
    }
    public bool Mute
    {
        get { return mute; }
        set
        {
            if (value != mute)
            {
                mute = value;
                foreach (KeyValuePair<SoundItem, SoundItem> item in allChannel)
                {
                    item.Key.Mute = value;
                }
            }
        }
    }
    /// <summary>
    /// 在指定坐标位置生成一个声音源，并播放指定声音
    /// </summary>
    /// <param name="_url"></param>
    /// <param name="_pos"></param>
    /// <param name="_loop"></param>
    /// <returns></returns>
    public SoundItem Play(string _url, Vector3 _pos, bool _loop = false)
    {
        GameObject _go = new GameObject("SoundClip");
        _go.transform.position = _pos;
        SoundItem _soundItem = Play(_url, _loop, _go);
        if (_soundItem == null)
        {
            GameObject.DestroyObject(_go);
        }
        else
        {
            _go.transform.parent = _soundItem.SoundPlayer.playObject.transform;
        }
        return _soundItem;
    }
    /// <summary>
    /// 根据路径播放指定声音
    /// </summary>
    /// <param name="_url"></param>
    /// <param name="_loop"></param>
    /// <param name="_go"></param>
    /// <returns></returns>
    public SoundItem Play(string _url, bool _loop = false, GameObject _go = null)
    {
        if (_url == null || _url == "")
        {
            return null;
        }

        if (singleChangleDuration != 0)
        {
            SoundItem _tempSoundItem = (SoundItem)singleChangleCatch[_url];
            if (_tempSoundItem != null)
            {
                if (singleChangleDuration == -1 && !_tempSoundItem.IsOver())
                {
                    return null;
                }
                else if (Time.time - _tempSoundItem.LastPlayTime < singleChangleDuration)
                {
                    return null;
                }
            }
        }

        SoundPlayer _soundPlayer = SoundManager.GetSoundPlayer(_url);
        SoundItem _soundItem = _soundPlayer.PlaySound(_loop, loadOverToPlay, _go);
        if (Mute)
        {
            _soundItem.Mute = true;
        }

        AddSoundItem(_soundItem);

        if (singleChangleDuration != 0)
        {
            singleChangleCatch[_url] = _soundItem;
        }

        if (volume != 1)
        {
            _soundItem.UpdateVolume();
        }
        return _soundItem;
    }
    /// <summary>
    /// 添加声音到组中
    /// </summary>
    /// <param name="_soundItem"></param>
    private void AddSoundItem(SoundItem _soundItem)
    {
        allChannel[_soundItem] = _soundItem;
        _soundItem.SoundGroup = this;
    }
    /// <summary>
    /// 声音播放完之后的回调函数
    /// </summary>
    /// <param name="_soundItem"></param>
    public void OnSoundOver(SoundItem _soundItem)
    {
        allChannel.Remove(_soundItem);
        singleChangleCatch.Remove(_soundItem.SoundPlayer.URL);
    }
    /// <summary>
    /// 关闭组内的所有声音
    /// </summary>
    public void StopAll()
    {
        foreach (KeyValuePair<SoundItem, SoundItem> item in allChannel)
        {
            item.Key.Stop();
        }
        allChannel.Clear();
    }
    #endregion
}