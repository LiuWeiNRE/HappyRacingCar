using System.Collections.Generic;
using UnityEngine;

/*
 * 一个声音的播放器，能播放一个声音文件。
 * 资源管理类：资源的加载和循环利用内存的技术--Pool池技术
 */
public class SoundPlayer
{
    #region -- 变量定义
    internal int soundCount = 0;//声音播放的计数器
    private string url;//声音路径
    //记录所有的声音Item值
    private Dictionary<SoundItem, SoundItem> allChannel = new Dictionary<SoundItem, SoundItem>();
    private List<AudioSource> unUsedPool;//未使用的Pool池
    private AudioClip clip;//具体的声音Clip。
    internal GameObject playObject;//游戏对象节点：播放声音的对象
    #endregion

    #region -- 自定义函数
    public SoundPlayer(string _url)
    {
        unUsedPool = new List<AudioSource>();
        url = _url;
        clip = ResourcesManager.Load<AudioClip>(url);
        if (clip == null)
        {
            Debug.LogError("not find sound file:" + url);
        }
        playObject = new GameObject(url);
        playObject.transform.parent = SoundManager.soundPlayerObject.transform;
    }
    internal void OnSoundOver(SoundItem _soundItem, bool _remove = true)
    {
        soundCount--;
        GameObject _go = _soundItem.AudioSource.gameObject;

        if (_go == playObject)
        {
            unUsedPool.Add(_soundItem.AudioSource);
            _soundItem.AudioSource.enabled = false;
        }
        else if (_go.name == "SoundClip")//具体看Item的初始化代码
        {
            GameObject.DestroyObject(_go);
        }
        else
        {
            GameObject.Destroy(_soundItem.AudioSource);
        }

        if (_soundItem.SoundGroup != null)
        {
            _soundItem.SoundGroup.OnSoundOver(_soundItem);
        }

        if (_remove)
        {
            allChannel.Remove(_soundItem);
        }
    }
    public void GC()
    {
        if (allChannel.Count == 0)
        {
            return;
        }

        List<SoundItem> _soundItems = new List<SoundItem>();
        foreach (KeyValuePair<SoundItem, SoundItem> item in allChannel)
        {
            if (item.Value.IsOver())
            {
                _soundItems.Add(item.Key);
            }
            else if (!item.Value.AudioSource.isPlaying)
            {
                _soundItems.Add(item.Key);
                OnSoundOver(item.Key, false);
            }
        }

        int _count = _soundItems.Count;
        if (_count != 0)
        {
            for (int i = 0; i < _count; i++)
            {
                allChannel.Remove(_soundItems[i]);
            }
        }
    }
    #endregion
}
