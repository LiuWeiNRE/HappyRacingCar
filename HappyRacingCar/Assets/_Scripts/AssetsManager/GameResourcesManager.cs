using UnityEngine;

public class GameResourcesManager 
{
    #region --变量定义
    public static string uiPath = "UIResources/UIPrefabs/";
    #endregion

    #region --系统函数

    #endregion

    #region --自定义函数
    /// <summary>
    /// 加载UI预制体
    /// </summary>
    /// <param name="pName"></param>
    /// <returns></returns>
    public static GameObject GetUIPrefab(string pName)
    {
        return ResourcesManager.Load<GameObject>(uiPath + pName);
    }
    #endregion
}
