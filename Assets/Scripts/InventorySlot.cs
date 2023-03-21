using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        // dropped item is from within the inventory
        UIItem uiItem = dropped.GetComponent<UIItem>();
        if (uiItem == null)
        {
            // dropped item was not an inventory item but is a gameobject
            //GameObject object = dropped.GetComponent<GameObject>();
        }
        if(transform.childCount >= 1)
        // if there is already an object in the slot
        {
            UIItem childUIItem = transform.GetChild(0).GetComponent<UIItem>();
            // if the inventory space is already taken up
            if(childUIItem != null)
            {
                // if the object is blank... 
                if(childUIItem.item == null)
                {
                    // replace blank item with image of gameobject and make gameobject inactive
                    transform.GetChild(0).SetParent(uiItem.parentAfterDrag); 
                    uiItem.parentAfterDrag = transform;
                }
                // otherwise, do nothing so that multiple items cannot be placed on top of each other
            }
        }
    }
}
