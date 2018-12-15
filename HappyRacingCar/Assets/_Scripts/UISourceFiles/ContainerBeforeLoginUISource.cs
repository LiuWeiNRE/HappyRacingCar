/* UISource File Create Data: 12/15/2018 11:57:18 PM*/

using UnityEngine;

public partial class ContainerBeforeLoginUIController : UIControllerBase
{
    private GameObject backGround;
    private Vector3 uiOriginalPositionBackGround;
    private GameObject logo;
    private Vector3 uiOriginalPositionLogo;


    public GameObject BackGround
    {
        get
        {
            if (backGround == null)
            {
                backGround = this.transform.Find("BackGround").gameObject;
                uiOriginalPositionBackGround = backGround.transform.localPosition;
            }
            return backGround;
        }
    }
    public Vector3 UIOriginalPositionBackGround
    {
        get
        {
            if (backGround == null)
            {
                return BackGround.transform.localPosition;
            }
            return uiOriginalPositionBackGround;
        }
    }
    public GameObject Logo
    {
        get
        {
            if (logo == null)
            {
                logo = this.transform.Find("Logo").gameObject;
                uiOriginalPositionLogo = logo.transform.localPosition;
            }
            return logo;
        }
    }
    public Vector3 UIOriginalPositionLogo
    {
        get
        {
            if (logo == null)
            {
                return Logo.transform.localPosition;
            }
            return uiOriginalPositionLogo;
        }
    }
}
