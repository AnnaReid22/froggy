using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToInventory : MonoBehaviour, IPointerClickHandler
{
    private Inventory inventory;
    private ItemDatabase database;
    int id = -1;

    public void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        database = GameObject.Find("ItemDatabase").GetComponent<ItemDatabase>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click");
        id = database.values[this.tag];
        if(id != -1)
        {
            Debug.Log("Found " + id);
            inventory.GiveItem(id);
            Destroy(this.gameObject);
        }
        else{Debug.Log("didn't find value");}
    }
}
