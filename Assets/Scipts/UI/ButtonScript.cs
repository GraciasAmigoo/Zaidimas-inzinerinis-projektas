
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject[] panels;

    public void OpenPanel(GameObject panelToOpen)
    {
        if (panelToOpen.activeSelf)
        {
            panelToOpen.SetActive(false);
        }
        else
        {
            // ájungia pasirinktà
            
            foreach (GameObject panel in panels)
            {
                panel.SetActive(false);
            }
            panelToOpen.SetActive(true);
        }
        // iðjungia visus langus


        
    }
}
