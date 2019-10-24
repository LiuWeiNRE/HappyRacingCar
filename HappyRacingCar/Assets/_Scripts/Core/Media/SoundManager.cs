using UnityEngine;
using System.Collections;

/*
 * 播放声音的管理类。针对游戏开发对声音进行了详细的分类管理。
 * 可以方便的对某一类声音进行停止,调整音量等操作。
 * 游戏中的声音可能分为音乐、音效。
 */
public class SoundManager
{
    #region -- 变量定义
    internal static Hashtable allSound = new Hashtable();//保存所有的声音路径和组信息，allSound[url] = player
    private static Hashtable allGroupInfo = new Hashtable();//保存组内信息 allGroupInfo[name] = soundGroup
    private static float volume = 1;//音量大小 0~1
    private static bool mute;//全局静音控制
    internal static GameObject soundPlayerObject;//常驻内存的声音对象
    private static SoundGroup bgSoundGroup;//背景组
    private static SoundGroup effectSoundGroup;//音效组
    private static AudioListener audioListener;//声音监听器
    #endregion

    #region -- 自定义函数
    public static SoundGroup BGSoundGroup
    {
        get
        {
            if (bgSoundGroup == null)
            {
                bgSoundGroup = GetSoundGroup("bg");
            }
            return bgSoundGroup;
        }
    }
    public static SoundGroup EffectSoundGroup
    {
        get
        {
            if (effectSoundGroup == null)
            {
                effectSoundGroup = GetSoundGroup("effect");
            }
            return effectSoundGroup;
        }
    }
    public static float Volume
    {
        get { return volume; }
        set
        {
            volume = value;
            AudioListener.volume = volume;
        }
    }
    public static bool Mute
    {
        get { return mute; }
        set
        {
            if (mute != value)
            {
                mute = value;
                foreach (SoundGroup item in allGroupInfo.Values)
                {
                    item.Mute = value;
                }
            }
        }
    }

    private static void Init()
    {
        GameObject _go = GameObject.Find("SoundPlayerObject");
        if (_go != null)
        {
            GameObject.DestroyObject(_go);
        }

        soundPlayerObject = new GameObject("SoundPlayerObject");
        GameObject.DontDestroyOnLoad(soundPlayerObject);
        soundPlayerObject.AddComponent<SoundRetriever>();

        if (audioListener == null)
        {
            ResetListener();
        }
    }
    /// <summary>
    /// 设置监听器对象。如果该物体上没有监听器，就在该物体上新增一个 AudioListener 组件。
    /// </summary>
    /// <param name="_target"></param>
    public static void SetListener(GameObject _target)
    {
        if (audioListener != null)
        {
            GameObject.Destroy(audioListener);
        }
        audioListener = _target.GetComponent<AudioListener>();
        if (audioListener == null)
        {
            audioListener = _target.AddComponent<AudioListener>();
        }
    }
    /// <summary>
    /// 设置监听器对象。
    /// </summary>
    /// <param name="_audioListener"></param>
    public static void SetListener(AudioListener _audioListener)
    {
        if (audioListener != null)
        {
            GameObject.Destroy(audioListener);
        }
        audioListener = _audioListener;
    }
    /// <summary>
    /// 重置监听器 AudioListener 组件，使场景中只存在一个监听器。
    /// 如果存在 MainCamera ,将监听器放到 MainCamera 上，否则将监听器放到 SoundPlayerObject 上。
    /// </summary>
    public static void ResetListener()
    {
        Camera[] _cameras = Camera.allCameras;
        foreach (Camera item in _cameras)
        {
            AudioListener _audioListener = item.gameObject.GetComponent<AudioListener>();
            if (_audioListener != null)
            {
                SetListener(_audioListener);
            }
        }

        if (audioListener == null)
        {
            if (Camera.main != null)
            {
                SetListener(Camera.main.gameObject);
            }
            else
            {
                SetListener(soundPlayerObject);
            }
        }
    }
    /// <summary>
    /// 根据组名称获取声音组对象
    /// </summary>
    /// <param name="_groupName"></param>
    /// <returns></returns>
    public static SoundGroup GetSoundGroup(string _groupName)
    {
        if (soundPlayerObject == null)
        {
            Init();
        }

        SoundGroup _soundGroup = (SoundGroup)allGroupInfo[_groupName];
        if (_soundGroup == null)
        {
            _soundGroup = new SoundGroup(_groupName);
            allGroupInfo[_groupName] = _soundGroup;
        }
        return _soundGroup;
    }
    /// <summary>
    /// 取得指定声音的播放器。
    /// </summary>
    /// <param name="_url"></param>
    /// <returns></returns>
    public static SoundPlayer GetSoundPlayer(string _url)
    {
        SoundPlayer _soundPlayer = (SoundPlayer)allSound[_url];
        if (_soundPlayer == null)
        {
            _soundPlayer = new SoundPlayer(_url);
            allSound[_url] = _soundPlayer;
        }
        return _soundPlayer;
    }
    /// <summary>
    /// 根据路径播放一个声音
    /// </summary>
    /// <param name="_url"></param>
    /// <param name="_loop"></param>
    /// <param name="_groupName"></param>
    /// <returns></returns>
    public static SoundItem Play(string _url, bool _loop = false, string _groupName = "effect")
    {
        SoundGroup _soundGroup = GetSoundGroup(_groupName);
        return _soundGroup.Play(_url, _loop);
    }
    /// <summary>
    /// 设置组的音量值
    /// </summary>
    /// <param name="_groupName"></param>
    /// <param name="_volume"></param>
    /// <param name="_time"></param>
    public static void SetGroupVolume(string _groupName, float _volume = 1, int _time = 1000)
    {
        GetSoundGroup(_groupName).Volume = _volume;
    }
    /// <summary>
    /// 关闭指定的声音
    /// </summary>
    /// <param name="_url"></param>
    public static void StopSound(string _url)
    {
        SoundPlayer _soundPlayer = GetSoundPlayer(_url);
        if (_soundPlayer != null)
        {
            _soundPlayer.StopAll();
        }
    }
    /// <summary>
    /// 关闭组内的所有声音
    /// </summary>
    /// <param name="_groupName"></param>
    public static void StopGroup(string _groupName)
    {
        GetSoundGroup(_groupName).StopAll();
    }
    /// <summary>
    /// 关闭所有声音
    /// </summary>
    public static void StopAll()
    {
        foreach (SoundPlayer item in allSound.Values)
        {
            item.StopAll();
        }
    }
    /// <summary>
    /// 释放声音，并放回释放结果
    /// </summary>
    /// <param name="_url"></param>
    /// <returns></returns>
    public static bool OnReleaseSound(string _url)
    {
        SoundPlayer _soundPlayer = (SoundPlayer)allSound[_url];
        if (_soundPlayer.soundCount <= 0)
        {
            allSound.Remove(_url);
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// 释放所有声音中Player中的内存
    /// </summary>
    public static void GC()
    {
        foreach (SoundPlayer item in allSound)
        {
            item.GC();
        }
    }
    #endregion
}