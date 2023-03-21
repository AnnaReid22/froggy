using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCanvas : MonoBehaviour
{
    public GameObject invCanvas; // inventory canvas to enable/disable
    private bool isActive; // bool if inventory is currently active

    void Start()
    {
        HideInventory();
        isActive = false;
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
