using UnityEngine;
using System.Collections;

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
    #endregion

    #region -- 系统函数

    #endregion

    #region -- 自定义函数

    #endregion
}