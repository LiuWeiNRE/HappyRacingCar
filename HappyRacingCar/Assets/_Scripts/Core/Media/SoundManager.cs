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
    internal static GameObject soundPlayerObject;//常驻内存的声音对象
    private static AudioListener audioListener;//声音监听器
    #endregion

    #region -- 系统函数

    #endregion

    #region -- 自定义函数
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