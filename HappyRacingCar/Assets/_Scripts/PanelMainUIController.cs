using UnityEngine;

public class PanelMainUIController : MonoBehaviour
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
                        GameObject uiMain = GameObject.Find("UIMain");
                        if (uiMain == null)
                        {
                            uiMain = GameObject.Find("UIMain(Clone)");
                        }

                        if (uiMain == null)
                        {
                            uiMain = (GameObject)(GameObject.Instantiate(GameResourcesManager.GetUIPrefab("UIMain")));
                        }
                        instance = uiMain.transform.Find("Camera/PanelMain").GetComponent<PanelMainUIController>();
                    }
                }
            }
            return instance;
        }
    }
    #endregion

    #region --自定义函数
    /// <summary>
    /// 添加UI界面
    /// </summary>
    /// <param name="_layer">UI层</param>
    /// <param name="_uiName">UI界面预制体名称</param>
    /// <returns></returns>
    public GameObject AddUIPanel(UILayer _layer, string _uiName)
    {
        GameObject addUI = GameResourcesManager.GetUIPrefab(_uiName);
        //addUI = NGUITools.AddChild(this.GetLayerContainer(layer), addUI);
        return addUI;
    }
    #endregion

    public enum UILayer : int
    {
        Debug=0,
        Background = 1,
        Bottom = 2,
        PopupWindow = 3,
        PopupTip = 4,
        Top = 5,
    }
}
