/* UI控制器父类
 * 1、实现可继承的 Close 方法。关闭UI界面。
 */
using UnityEngine;

public class UIControllerBase : MonoBehaviour 
{
    #region --自定义函数
    public void Close()
    {
        Destroy(this.gameObject);
    }
    #endregion
}
