using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items; // list of items
    public GameObject paperPrefab;
    public GameObject bottlePrefab;
    public GameObject canPrefab;
    public GameObject bambooSeedPrefab;
    public GameObject bdSeedPrefab;
    public GameObject blSeedPrefab;
    public GameObject odSeedPrefab;
    public GameObject olSeedPrefab;
    public GameObject kdSeedPrefab;
    public GameObject klSeedPrefab;
    public GameObject pdSeedPrefab;
    public GameObject plSeedPrefab;
    public GameObject treeSeedPrefab1;
    public GameObject treeSeedPrefab2;
    public GameObject treeSeedPrefab3;
    public GameObject treeSeedPrefab4;
    public GameObject bucketPrefab;
    public GameObject rockPrefab;
    // storing key-value pairs for object tags to id's
    public Dictionary<string, int> values = new Dictionary<string, int>
    {
        {"Paper", 0}, {"Bottle", 1}, {"Can", 2}, {"Bamboo Seeds", 3}, {"daisy_blue", 4}, {"lily_blue", 5},
        {"daisy_orange", 6}, {"lily_orange", 7}, {"daisy_pink", 8}, {"lily_pink", 9},
        {"daisy_purple", 10}, {"lily_purple", 11}, {"tree1", 12}, {"tree2", 13}, {"tree3", 14}, {"tree4", 15},
        {"Bucket", 16}, {"Rock", 17}
    };

    private void Awake()
    {
        BuildData();
    }
    // find item in list by id
    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    // find item in list by title
    public Item GetItem(string itemTitle)
    {
        return items.Find(item => item.title == itemTitle);
    }

    // build database
    void BuildData()
    {
        items = new List<Item>(){
            // trash items
            new Item(0, "Paper", "A wad of paper.", "Trash 01 Paper Wad", "trash", paperPrefab),
            new Item(1, "Bottle", "A plastic bottle.", "Trash 02 Water Bottle", "trash", bottlePrefab),
            new Item(2, "Can", "A crushed aluminum can.", "Trash 03 Can", "trash", canPrefab),
            // seeds
            new Item(3, "Bamboo Seeds", "Seeds that will grow bamboo.", "bamboo_seeds", "plants/seeds", bambooSeedPrefab),
            new Item(4, "Blue Daisy Seeds", "Seeds that will grow a daisy.", "blue_daisy_seeds", "plants/seeds",bdSeedPrefab),
            new Item(5, "Blue Lily Seeds", "Seeds that will grow a lily.", "blue_lily_seeds", "plants/seeds",blSeedPrefab),
            new Item(6, "Orange Daisy Seeds", "Seeds that will grow a daisy.", "orange_daisy_seeds", "plants/seeds",odSeedPrefab),
            new Item(7, "Orange Lily Seeds", "Seeds that will grow a lily.", "orange_lily_seeds", "plants/seeds", olSeedPrefab),
            new Item(8, "Pink Daisy Seeds", "Seeds that will grow a daisy.", "pink_daisy_seeds", "plants/seeds", kdSeedPrefab),
            new Item(9, "Pink Lily Seeds", "Seeds that will grow a lily.", "pink_lily_seeds", "plants/seeds", klSeedPrefab),
            new Item(10, "Purple Daisy Seeds", "Seeds that will grow a daisy.", "purple_daisy_seeds", "plants/seeds", pdSeedPrefab),
            new Item(11, "Purple Lily Seeds", "Seeds that will grow a lily.", "purple_lily_seeds", "plants/seeds", plSeedPrefab),
            new Item(12, "Tree Seeds", "Seeds that will grow a flowering tree.", "tree_seeds", "plants/seeds", treeSeedPrefab1),
            new Item(13, "Tree Seeds", "Seeds that will grow a flowering tree.", "tree_seeds", "plants/seeds", treeSeedPrefab2),
            new Item(14, "Tree Seeds", "Seeds that will grow a flowering tree.", "tree_seeds", "plants/seeds", treeSeedPrefab3),
            new Item(15, "Tree Seeds", "Seeds that will grow a flowering tree.", "tree_seeds", "plants/seeds", treeSeedPrefab4),
            // pond items
            new Item(16, "Water Bucket", "Bucket filled with freshwater.", "Bucket", "pond", bucketPrefab),
            new Item(17, "Rock", "Heavy rock.", "Rock", "pond", rockPrefab)
        };
    }
}
