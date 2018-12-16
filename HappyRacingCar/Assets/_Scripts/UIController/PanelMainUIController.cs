/* UI界面控制器
 * 1、使用单例模式
 * 2、封装获取UI层级的方法
 * 3、封装添加UI界面的方法
 * 4、封装清除所有UI界面的方法
 * 5、实现进入登陆界面的方法
 */
using UnityEngine;

public partial class PanelMainUIController : UIControllerBase
{
    #region --变量定义
    private static PanelMainUIController instance;
    private static readonly object lockHelper = new object();
    #endregion

    #region --系统函数
    private void OnDestroy()
    {
        instance = null;
    }
    #endregion

    #region --属性
    public static PanelMainUIController Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockHelper)       //单利有出现2个UIMain的低概率
                {
                    if (instance == null)
                    {
                        GameObject _uiMain = GameObject.Find("UIMain");
                        if (_uiMain == null)
                        {
                            _uiMain = GameObject.Find("UIMain(Clone)");
                        }
                        if (_uiMain == null)
                        {
                            _uiMain = GameObject.Instantiate(GameResourcesManager.GetUIPrefab("UIMain"));
                        }
                        instance = _uiMain.transform.Find("PanelMain").GetComponent<PanelMainUIController>();
                    }
                }
            }
            return instance;
        }
    }
    #endregion

    #region --自定义函数
    /// <summary>
    /// 从 Resources 文件夹下加载 UI 界面，并添加到指定层。
    /// </summary>
    /// <param name="_layer">UI层</param>
    /// <param name="_uiName">UI界面名称</param>
    /// <returns></returns>
    public GameObject AddUIPanel(UILayer _layer, string _uiName)
    {
        GameObject _addUI = GameResourcesManager.GetUIPrefab(_uiName);
        _addUI.transform.SetParent(GetUILayer(_layer).transform, false);
        return _addUI;
    }
    /// <summary>
    /// 清除所有的UI界面，但不包括 UILayer.Debug 层下的UI.
    /// </summary>
    public void CleanAllUI()
    {
        foreach (Transform item in this.PanelBackground.transform)
        {
            Destroy(item.gameObject);
        }
        foreach (Transform item in this.PanelBottom.transform)
        {
            Destroy(item.gameObject);
        }
        foreach (Transform item in this.PanelPopupWindow.transform)
        {
            Destroy(item.gameObject);
        }
        foreach (Transform item in this.PanelPopupTip.transform)
        {
            Destroy(item.gameObject);
        }
        foreach (Transform item in this.PanelTop.transform)
        {
            Destroy(item.gameObject);
        }
    }
    /// <summary>
    /// 获取UI层级父物体
    /// </summary>
    /// <param name="_layer">UI层</param>
    /// <returns></returns>
    private GameObject GetUILayer(UILayer _layer)
    {
        switch (_layer)
        {
            case UILayer.Debug:
                return this.PanelDebug;
            case UILayer.Background:
                return this.PanelBackground;
            case UILayer.Bottom:
                return this.PanelBottom;
            case UILayer.PopupWindow:
                return this.PanelPopupWindow;
            case UILayer.PopupTip:
                return this.PanelPopupTip;
            case UILayer.Top:
                return this.PanelTop;
            default:
                return null;
        }
    }

    /// <summary>
    /// 进入登陆界面
    /// </summary>
    public void EnterLoginPanel()
    {
        CleanAllUI();
        AddUIPanel(UILayer.Bottom, "ContainerLogindenglu");
        if (UIControllerConst.DEBUG_FPS)
        {
            AddUIPanel(UILayer.Debug, "DebugFPS");
        }
    }
    #endregion

    /// <summary>
    /// UI层级
    /// </summary>
    public enum UILayer : int
    {
        Debug = 0,
        Background = 1,
        Bottom = 2,
        PopupWindow = 3,
        PopupTip = 4,
        Top = 5,
    }
}
