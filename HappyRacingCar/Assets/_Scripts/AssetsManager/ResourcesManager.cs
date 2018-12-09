using UnityEngine;

public class ResourcesManager
{
    #region --变量定义
    private static ResourcesManager instance;
    #endregion

    #region --属性
    public static ResourcesManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ResourcesManager();
            }
            return instance;
        }
    }
    #endregion

    #region --自定义函数
    /// <summary>
    /// 从Resources文件夹下加载资源
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="assetPath"></param>
    /// <returns></returns>
    public static T Load<T>(string assetPath) where T : Object
    {
        return Resources.Load<T>(assetPath);
    }
    #endregion
}
