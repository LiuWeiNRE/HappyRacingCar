using UnityEngine;

/*
 * 内存回收。间隔固定时间释放内存。
 */
public class SoundRetriever : MonoBehaviour
{
    #region -- 变量定义
    private const float FIXED_UPDATE_TIME = 0.5F;   //固定间隔时间
    private float time = 0;                         //计时时间
    #endregion

    #region -- 系统函数
    private void FixedUpdate()
    {
        FixedGC();
    }
    #endregion

    #region -- 自定义函数
    private void FixedGC()
    {
        time += Time.deltaTime;
        if (time >= FIXED_UPDATE_TIME)
        {
            time = 0;
            SoundManager.GC();
        }
    }
    #endregion
}
