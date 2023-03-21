using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCanvas : MonoBehaviour
{
    public GameObject invCanvas; // inventory canvas to enable/disable
    private bool isActive; // bool if inventory is currently active
    GameObject toggle; // toggle button

    void Start()
    {
        toggle = GameObject.Find("Toggle");
        if(!toggle.GetComponent<Toggle>().isOn)
        {
            HideInventory();
            isActive = false;
        }
        else
        {
            ShowInventory();
            isActive = true;
        }
    }
    // Open inventory when inventory button is clicked
    public void ChangeInventoryState()
    {
        if(isActive){HideInventory();}
        else{ShowInventory();}
    }
    private void ShowInventory()
    {
        invCanvas.SetActive(true);
        isActive = true;
    }

    private void HideInventory()
    {
        invCanvas.SetActive(false);
        isActive = false;
    }
}
