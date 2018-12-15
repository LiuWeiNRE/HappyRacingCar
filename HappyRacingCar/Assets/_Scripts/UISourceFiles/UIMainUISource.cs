/* UISource File Create Data: 12/15/2018 11:58:57 PM*/

using UnityEngine;

public partial class UIMainUIController : UIControllerBase
{
    private GameObject panelMain;
    private Vector3 uiOriginalPositionPanelMain;
    private GameObject eventSystem;
    private Vector3 uiOriginalPositionEventSystem;


    public GameObject PanelMain
    {
        get
        {
            if (panelMain == null)
            {
                panelMain = this.transform.Find("PanelMain").gameObject;
                uiOriginalPositionPanelMain = panelMain.transform.localPosition;
            }
            return panelMain;
        }
    }
    public Vector3 UIOriginalPositionPanelMain
    {
        get
        {
            if (panelMain == null)
            {
                return PanelMain.transform.localPosition;
            }
            return uiOriginalPositionPanelMain;
        }
    }
    public GameObject EventSystem
    {
        get
        {
            if (eventSystem == null)
            {
                eventSystem = this.transform.Find("EventSystem").gameObject;
                uiOriginalPositionEventSystem = eventSystem.transform.localPosition;
            }
            return eventSystem;
        }
    }
    public Vector3 UIOriginalPositionEventSystem
    {
        get
        {
            if (eventSystem == null)
            {
                return EventSystem.transform.localPosition;
            }
            return uiOriginalPositionEventSystem;
        }
    }
}
