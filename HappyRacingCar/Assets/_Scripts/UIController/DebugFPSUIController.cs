/*实时显示游戏的FPS值
 * 1、初始化
 * 2、更新FPS值。
 */

using UnityEngine;
using UnityEngine.UI;

public partial class DebugFPSUIController : UIControllerBase
{
    #region --变量定义
    private Text showFpsText;

    private int framesNumber;//帧数
    private float lastTime;//最后时间
    private float fps;
    #endregion

    #region --系统函数
    private void Start()
    {
        Init();
    }
    private void Update()
    {
        UpdateFPS();
    }
    #endregion

    #region --自定义函数
    private void Init()
    {
        if (UIControllerConst.DEBUG_FPS)
        {
            showFpsText = this.FPSText.GetComponent<Text>();
            framesNumber = 0;
            lastTime = 0f;
            fps = 0f;
        }
    }
    private void UpdateFPS()
    {
        if (UIControllerConst.DEBUG_FPS)
        {
            framesNumber++;
            if (Time.realtimeSinceStartup > lastTime + 0.5f)
            {
                fps = framesNumber / (Time.realtimeSinceStartup - lastTime);
                framesNumber = 0;
                lastTime = Time.realtimeSinceStartup;
                showFpsText.text = "FPS：" + fps.ToString("f2");
            }
        }
    }
    #endregion
}
