/*加载各种游戏物体的工具方法*/
using UnityEngine;

public class GameResourcesManager 
{
    #region --变量定义
    public const string UI_PATH = "UIResources/UIPrefabs/";//UI预制体的路径
    #endregion

    #region --自定义函数
    /// <summary>
    /// 加载UI预制体
    /// </summary>
    /// <param name="_name"></param>
    /// <returns></returns>
    public static GameObject GetUIPrefab(string _name)
    {
        return ResourcesManager.Load<GameObject>(UI_PATH + _name);
    }
    #endregion
}
