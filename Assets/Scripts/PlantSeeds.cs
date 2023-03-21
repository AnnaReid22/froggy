using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantSeeds : MonoBehaviour
{

    public Button btn; 
    private  List<GameObject> seeds; 
    private List<GameObject> sprouts; 
    private List<Vector3> originalPos; 
    private List<string> flowers;
    private List<string> trees; 
    private Vector3 position; 
    private float x_pos, x_cam;
    Camera cam;

    private Inventory inventory;

    void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        // give the player starting seeds
        for(int i = 4; i < 16; i++)
        {
            inventory.GiveItem(i);
        }

        seeds = new List<GameObject> {GameObject.FindWithTag("lily_purple"), GameObject.FindWithTag("lily_pink"), GameObject.FindWithTag("lily_orange"), 
        GameObject.FindWithTag("lily_blue"), GameObject.FindWithTag("daisy_blue"), GameObject.FindWithTag("daisy_orange"), 
        GameObject.FindWithTag("daisy_pink"), GameObject.FindWithTag("daisy_purple"),
        GameObject.FindWithTag("tree1"), GameObject.FindWithTag("tree2"), GameObject.FindWithTag("tree3"), GameObject.FindWithTag("tree4")}; 

        //originalPos = new List<Vector3> {GameObject.FindWithTag("lily_purple").transform.position, GameObject.FindWithTag("lily_pink").transform.position, GameObject.FindWithTag("lily_orange").transform.position, 
        //GameObject.FindWithTag("lily_blue").transform.position, GameObject.FindWithTag("daisy_blue").transform.position, GameObject.FindWithTag("daisy_orange").transform.position, 
        //GameObject.FindWithTag("daisy_pink").transform.position, GameObject.FindWithTag("daisy_purple").transform.position, 
        //GameObject.FindWithTag("tree1").transform.position, GameObject.FindWithTag("tree2").transform.position, GameObject.FindWithTag("tree3").transform.position, GameObject.FindWithTag("tree4").transform.position}; 


        sprouts = new List<GameObject> {GameObject.FindWithTag("tree_sprout_1"), GameObject.FindWithTag("tree_sprout_2"), GameObject.FindWithTag("tree_sprout_3"),  GameObject.FindWithTag("tree_sprout_4"),
        GameObject.FindWithTag("orange_daisy_sprout"), GameObject.FindWithTag("pink_daisy_sprout"), GameObject.FindWithTag("blue_daisy_sprout"), GameObject.FindWithTag("purple_daisy_sprout"),
        GameObject.FindWithTag("orange_lily_sprout"), GameObject.FindWithTag("pink_lily_sprout"), GameObject.FindWithTag("blue_lily_sprout"), GameObject.FindWithTag("purple_lily_sprout")}; 
        
        foreach (GameObject sprout in sprouts) {
            sprout.SetActive(false);
        }

        // when seeds are in inventory
        //foreach(GameObject seed in seeds)
        //{
        //    seed.SetActive(false);
        //}

        flowers = new List<string> {"lily_purple", "lily_pink", "lily_orange", "lily_blue", "daisy_blue", "daisy_orange", "daisy_pink", "daisy_purple"}; 
        trees = new List<string> {"tree1", "tree2", "tree3", "tree4"}; 

        cam = Camera.main; 
        btn.onClick.AddListener(plantSeeds);
    }

    void Update()
    {
        //for (int i = 0; i < seeds.Count; i++) {
        //    if (seeds[i].transform.position.y > 2.75) {
        //        x_pos= originalPos[i].x;  
        //        x_cam = cam.transform.position.x; 
        //        seeds[i].transform.position = new Vector3(x_pos + x_cam, seeds[i].transform.position.y, 0); 
        //    }
        //}             
    }

    public void plantSeeds() { 
        // get seed objects since they didn't exist outside of inventory
        seeds = new List<GameObject> {GameObject.FindWithTag("lily_purple"), GameObject.FindWithTag("lily_pink"), GameObject.FindWithTag("lily_orange"), 
        GameObject.FindWithTag("lily_blue"), GameObject.FindWithTag("daisy_blue"), GameObject.FindWithTag("daisy_orange"), 
        GameObject.FindWithTag("daisy_pink"), GameObject.FindWithTag("daisy_purple"),
        GameObject.FindWithTag("tree1"), GameObject.FindWithTag("tree2"), GameObject.FindWithTag("tree3"), GameObject.FindWithTag("tree4")}; 

        foreach (GameObject seed in seeds) {
            if (seed != null && flowers.Contains(seed.tag)) {
                if (seed.tag == "daisy_orange") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[4].SetActive(true); 
                        sprouts[4].transform.position = position; 
                        locations.orange_daisy = sprouts[4].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "daisy_pink") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[5].SetActive(true); 
                        sprouts[5].transform.position = position; 
                        locations.pink_daisy = sprouts[5].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "daisy_blue") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[6].SetActive(true); 
                        sprouts[6].transform.position = position; 
                        locations.blue_daisy = sprouts[6].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "daisy_purple") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[7].SetActive(true); 
                        sprouts[7].transform.position = position; 
                        locations.purple_daisy = sprouts[7].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "lily_orange") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[8].SetActive(true); 
                        sprouts[8].transform.position = position; 
                        locations.orange_lily = sprouts[8].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "lily_pink") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[9].SetActive(true); 
                        sprouts[9].transform.position = position; 
                        locations.pink_lily = sprouts[9].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "lily_blue") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[10].SetActive(true); 
                        sprouts[10].transform.position = position; 
                        locations.blue_lily = sprouts[10].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "lily_purple") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[11].SetActive(true); 
                        sprouts[11].transform.position = position; 
                        locations.purple_lily = sprouts[11].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                }
            } else if (seed != null && trees.Contains(seed.tag)) {
                if (seed.tag == "tree1") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        seed.SetActive(false); 
                        sprouts[0].SetActive(true); 
                        sprouts[0].transform.position = position; 
                        locations.tree1 = sprouts[0].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "tree2") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[1].SetActive(true); 
                        sprouts[1].transform.position = position; 
                        locations.tree2 = sprouts[1].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "tree3") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[2].SetActive(true); 
                        sprouts[2].transform.position = position; 
                        locations.tree3 = sprouts[2].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } else if (seed.tag == "tree4") {
                    position = seed.transform.position;
                    seed.SetActive(false); 
                    if (seed.transform.position.y < 0) {
                        sprouts[3].SetActive(true); 
                        sprouts[3].transform.position = position; 
                        locations.tree4 = sprouts[3].transform.position; 
                        Score.planting_score += 2;
                        Debug.Log("Planting Score: " + Score.planting_score);
                    }
                } 
            } else {
                if(seed != null){seed.SetActive(false);}
            }
        }
    }
}
