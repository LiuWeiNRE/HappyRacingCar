using DG.Tweening;

public partial class ContainerBeforeLoginUIController : UIControllerBase 
{
    #region --变量定义

    #endregion

    #region --系统函数
    private void Start()
    {
        //1.2秒后执行开机动画，并进入登陆界面
        DOVirtual.DelayedCall(1.2f, delegate ()
         {
             Tweener _tweener = this.Logo.transform.DOScale(0, 1f);
             _tweener.OnComplete(delegate ()
             {
                 PanelMainUIController.Instance.EnterLoginPanel();
             });
         });
    }
    #endregion

    #region --自定义函数

    #endregion
}
