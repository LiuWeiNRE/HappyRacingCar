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

    #endregion

    #region -- 系统函数

    #endregion

    #region -- 自定义函数
    /// <summary>
    /// 重置监听器 AudioListener 组件，使场景中只存在一个监听器。
    /// 如果存在 MainCamera ,将监听器放到 MainCamera 上，否则将监听器放到 SoundPlayerObject 上。
    /// </summary>
    public static void ResetListener()
    { }
    /// <summary>
    /// 释放所有声音中Player中的内存
    /// </summary>
    public static void GC()
    { }
    #endregion
}