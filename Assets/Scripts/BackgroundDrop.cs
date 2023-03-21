using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackgroundDrop : MonoBehaviour, IDropHandler
{
    public Inventory inventory;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        // dropped item is from within the inventory
        UIItem uiItem = dropped.GetComponent<UIItem>();
        if (uiItem != null)
        {
            Debug.Log("dropped");
            GameObject newObj = Instantiate(uiItem.item.gameobj);
            newObj.transform.position = uiItem.transform.position;
            inventory.RemoveItem(uiItem.item.id);
        }

    }
}
