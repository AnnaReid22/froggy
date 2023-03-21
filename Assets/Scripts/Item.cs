using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Inspired and modified from https://medium.com/@yonem9/create-an-unity-inventory-part-1-basic-data-model-3b54451e25ec

public class Item
{
    public Sprite image;
    public int id;
    public string description; // description of item to display
    public string title; // title of item to display
    public string filename; // name of image in assets folder
    public string category; // what scene the item belongs to or what folder in assets
    public GameObject gameobj; // the actual gameobject tied to the item

    // constructor to create an item
    public Item(int id, string title, string descript, string filename, string category, GameObject obj)
    {
        this.id = id;
        this.title = title;
        this.description = descript;
        this.category = category;
        this.filename = filename;
        this.gameobj = obj;
        this.image = Resources.Load<Sprite>("Art/" + category + "/" + filename); // load sprite image from art folder
    }

    // constructor to copy an item
    public Item(Item other)
    {
        this.id = other.id;
        this.title = other.title;
        this.description = other.description;
        this.category = other.category;
        this.filename = other.filename;
        this.gameobj = other.gameobj;
        this.image = Resources.Load<Sprite>("Art/" + other.category + "/" + other.filename);
    }

    public override bool Equals(object obj)
    {
        Item check = obj as Item;
        return (this.id == check.id);
    }
}
