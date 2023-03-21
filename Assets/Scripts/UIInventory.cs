using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// inspired and modified from https://medium.com/@yonem9/create-an-unity-inventory-part-4-display-items-in-ui-6cdac8f734b7

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uiItems = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int slotNum = 15; // total number of slots

    private void Awake()
    {
        for(int i = 0; i < slotNum; i++)
        {
            GameObject slotInstance = Instantiate(slotPrefab,slotPanel,false);
            // add this as a child to the panel
            //slotInstance.transform.SetParent(slotPanel);
            // add relevant item to ui items list
            uiItems.Add(slotInstance.GetComponentInChildren<UIItem>());
        }
    }
    // function to show or hide any item
    public void UpdateSlot(int slot, Item item)
    {
        uiItems[slot].UpdateItem(item);
    }
    // function to add item to inventory
    public void AddItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(uitem => uitem.item == null),item);
    }
    // function to remove items from inventory
    public void RemoveItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(uitem => uitem.item == item),null);
    }
}
