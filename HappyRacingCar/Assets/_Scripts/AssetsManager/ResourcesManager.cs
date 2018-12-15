/*从 Resources 文件夹下加载各种资源的工具类*/
using UnityEngine;

public class ResourcesManager
{
    #region --自定义函数
    /// <summary>
    /// 根据路径从 Resources 文件夹加载类型为 T 的资源
    /// </summary>
    /// <typeparam name="T">资源类型</typeparam>
    /// <param name="_assetPath">资源路径。相对于 Resources 文件夹的路径</param>
    /// <returns></returns>
    public static T Load<T>(string _assetPath) where T : Object
    {
        return Resources.Load<T>(_assetPath);
    }
    #endregion
}
