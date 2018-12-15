/* UISource File Create Data: 12/15/2018 11:55:59 PM*/

using UnityEngine;

public partial class ContainerLogindengluUIController : UIControllerBase
{
    private GameObject containerBackground;
    private Vector3 uiOriginalPositionContainerBackground;
    private GameObject buttonQiehuanzhanghao;
    private Vector3 uiOriginalPositionButtonQiehuanzhanghao;
    private GameObject buttonPingtaidenglu;
    private Vector3 uiOriginalPositionButtonPingtaidenglu;
    private GameObject buttonKaishiyouxi;
    private Vector3 uiOriginalPositionButtonKaishiyouxi;


    public GameObject ContainerBackground
    {
        get
        {
            if (containerBackground == null)
            {
                containerBackground = this.transform.Find("ContainerBackground").gameObject;
                uiOriginalPositionContainerBackground = containerBackground.transform.localPosition;
            }
            return containerBackground;
        }
    }
    public Vector3 UIOriginalPositionContainerBackground
    {
        get
        {
            if (containerBackground == null)
            {
                return ContainerBackground.transform.localPosition;
            }
            return uiOriginalPositionContainerBackground;
        }
    }
    public GameObject ButtonQiehuanzhanghao
    {
        get
        {
            if (buttonQiehuanzhanghao == null)
            {
                buttonQiehuanzhanghao = this.transform.Find("ButtonQiehuanzhanghao").gameObject;
                uiOriginalPositionButtonQiehuanzhanghao = buttonQiehuanzhanghao.transform.localPosition;
            }
            return buttonQiehuanzhanghao;
        }
    }
    public Vector3 UIOriginalPositionButtonQiehuanzhanghao
    {
        get
        {
            if (buttonQiehuanzhanghao == null)
            {
                return ButtonQiehuanzhanghao.transform.localPosition;
            }
            return uiOriginalPositionButtonQiehuanzhanghao;
        }
    }
    public GameObject ButtonPingtaidenglu
    {
        get
        {
            if (buttonPingtaidenglu == null)
            {
                buttonPingtaidenglu = this.transform.Find("ButtonPingtaidenglu").gameObject;
                uiOriginalPositionButtonPingtaidenglu = buttonPingtaidenglu.transform.localPosition;
            }
            return buttonPingtaidenglu;
        }
    }
    public Vector3 UIOriginalPositionButtonPingtaidenglu
    {
        get
        {
            if (buttonPingtaidenglu == null)
            {
                return ButtonPingtaidenglu.transform.localPosition;
            }
            return uiOriginalPositionButtonPingtaidenglu;
        }
    }
    public GameObject ButtonKaishiyouxi
    {
        get
        {
            if (buttonKaishiyouxi == null)
            {
                buttonKaishiyouxi = this.transform.Find("ButtonKaishiyouxi").gameObject;
                uiOriginalPositionButtonKaishiyouxi = buttonKaishiyouxi.transform.localPosition;
            }
            return buttonKaishiyouxi;
        }
    }
    public Vector3 UIOriginalPositionButtonKaishiyouxi
    {
        get
        {
            if (buttonKaishiyouxi == null)
            {
                return ButtonKaishiyouxi.transform.localPosition;
            }
            return uiOriginalPositionButtonKaishiyouxi;
        }
    }
}
