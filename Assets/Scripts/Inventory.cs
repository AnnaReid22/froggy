using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> playerItems = new List<Item>();
    public ItemDatabase database;
    public UIInventory uiInventory;

    private void Start()
    {   
        GiveItem("Rock");
        GiveItem(1);
        GiveItem(3);
    }

    // function to give an item to the player
    public void GiveItem(int id)
    {
        Item newItem = database.GetItem(id);
        playerItems.Add(newItem);
        uiInventory.AddItem(newItem);
        Debug.Log("added " + newItem.title);
    }

    // function to give an item to the player using name instead of id
    public void GiveItem(string itemTitle)
    {
        Item newItem = database.GetItem(itemTitle);
        playerItems.Add(newItem);
        uiInventory.AddItem(newItem);
        Debug.Log("added " + newItem.title);
    }

    // function to check if an item is in a player's inventory
    public Item CheckItem(int id)
    {
        foreach(Item item in playerItems)
        {
            if(item.id == id)
            {
                return item;
            }
        }
        return null;
    }

    // function to remove an item from an inventory
    public void RemoveItem(int id)
    {
        Item toRemove = CheckItem(id);
        if (toRemove != null)
        {
            playerItems.Remove(toRemove);
            uiInventory.RemoveItem(toRemove);
            Debug.Log("removed " + toRemove.title);
        }
    }

}
