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
    private List<string> bamboos;  
    private Vector3 position; 

    void Start()
    {
        seeds = new List<GameObject> {GameObject.FindWithTag("lily_purple"), GameObject.FindWithTag("lily_pink"), GameObject.FindWithTag("lily_orange"), 
        GameObject.FindWithTag("lily_blue"), GameObject.FindWithTag("daisy_blue"), GameObject.FindWithTag("daisy_orange"), 
        GameObject.FindWithTag("daisy_pink"), GameObject.FindWithTag("daisy_purple"), 
        GameObject.FindWithTag("bamboo1"), GameObject.FindWithTag("bamboo2"), GameObject.FindWithTag("bamboo3"),
        GameObject.FindWithTag("tree1"), GameObject.FindWithTag("tree2"), GameObject.FindWithTag("tree3")}; 

        originalPos = new List<Vector3> {GameObject.FindWithTag("lily_purple").transform.position, GameObject.FindWithTag("lily_pink").transform.position, GameObject.FindWithTag("lily_orange").transform.position, 
        GameObject.FindWithTag("lily_blue").transform.position, GameObject.FindWithTag("daisy_blue").transform.position, GameObject.FindWithTag("daisy_orange").transform.position, 
        GameObject.FindWithTag("daisy_pink").transform.position, GameObject.FindWithTag("daisy_purple").transform.position, 
        GameObject.FindWithTag("bamboo1").transform.position, GameObject.FindWithTag("bamboo2").transform.position, GameObject.FindWithTag("bamboo3").transform.position,
        GameObject.FindWithTag("tree1").transform.position, GameObject.FindWithTag("tree2").transform.position, GameObject.FindWithTag("tree3").transform.position}; 

        sprouts = new List<GameObject> {GameObject.FindWithTag("bamboo_sprout_1"), GameObject.FindWithTag("bamboo_sprout_2"), GameObject.FindWithTag("bamboo_sprout_3"),
        GameObject.FindWithTag("tree_sprout_1"), GameObject.FindWithTag("tree_sprout_2"), GameObject.FindWithTag("tree_sprout_3"),
        GameObject.FindWithTag("orange_daisy_sprout"), GameObject.FindWithTag("pink_daisy_sprout"), GameObject.FindWithTag("blue_daisy_sprout"), GameObject.FindWithTag("purple_daisy_sprout"),
        GameObject.FindWithTag("orange_lily_sprout"), GameObject.FindWithTag("pink_lily_sprout"), GameObject.FindWithTag("blue_lily_sprout"), GameObject.FindWithTag("purple_lily_sprout")}; 
        foreach (GameObject sprout in sprouts) {
            sprout.SetActive(false); 
        }

        flowers = new List<string> {"lily_purple", "lily_pink", "lily_orange", "lily_blue", "daisy_blue", "daisy_orange", "daisy_pink", "daisy_purple"}; 
        trees = new List<string> {"tree1", "tree2", "tree3"}; 
        bamboos = new List<string> {"bamboo1", "bamboo2", "bamboo3"}; 

        btn.onClick.AddListener(plantSeeds);
    }

    void Update()
    {

    }

    void plantSeeds() { 
        foreach (GameObject seed in seeds) {
            if (seed.transform.position.y < -0.25) {
                if (flowers.Contains(seed.tag)) {
                    if (seed.tag == "daisy_orange") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[5]) {
                            sprouts[6].SetActive(true); 
                            sprouts[6].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "daisy_pink") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[6]) {
                            sprouts[7].SetActive(true); 
                            sprouts[7].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "daisy_blue") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[4]) {
                            sprouts[8].SetActive(true); 
                            sprouts[8].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "daisy_purple") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[7]) {
                            sprouts[9].SetActive(true); 
                            sprouts[9].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "lily_orange") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[2]) {
                            sprouts[10].SetActive(true); 
                            sprouts[10].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "lily_pink") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[1]) {
                            sprouts[11].SetActive(true); 
                            sprouts[11].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "lily_blue") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[3]) {
                            sprouts[12].SetActive(true); 
                            sprouts[12].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "lily_purple") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[0]) {
                            sprouts[13].SetActive(true); 
                            sprouts[13].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    }
                } else if (trees.Contains(seed.tag)) {
                    if (seed.tag == "tree1") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[11]) {
                            seed.SetActive(false); 
                            sprouts[3].SetActive(true); 
                            sprouts[3].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "tree2") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[12]) {
                            sprouts[4].SetActive(true); 
                            sprouts[4].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "tree3") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[13]) {
                            sprouts[5].SetActive(true); 
                            sprouts[5].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    }
                } else if (bamboos.Contains(seed.tag)) {
                    if (seed.tag == "bamboo1") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[8]) {
                            sprouts[0].SetActive(true); 
                            sprouts[0].transform.position = position;
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score); 
                        }
                    } else if (seed.tag == "bamboo2") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[9]) {
                            sprouts[1].SetActive(true); 
                            sprouts[1].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    } else if (seed.tag == "bamboo3") {
                        position = seed.transform.position;
                        seed.SetActive(false); 
                        if (seed.transform.position != originalPos[10]) {
                            sprouts[2].SetActive(true); 
                            sprouts[2].transform.position = position; 
                            Score.planting_score += 1;
                            Debug.Log("Planting Score: " + Score.planting_score);
                        }
                    }
                }
            } else {
                seed.SetActive(false); 
            }
        }
    }
}
