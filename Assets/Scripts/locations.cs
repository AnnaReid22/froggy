using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class locations : MonoBehaviour
{
    public static Vector3 blue_lily; 
    public static Vector3 pink_lily; 
    public static Vector3 orange_lily; 
    public static Vector3 purple_lily; 
    public static Vector3 blue_daisy; 
    public static Vector3 pink_daisy; 
    public static Vector3 orange_daisy; 
    public static Vector3 purple_daisy; 
    public static Vector3 tree1; 
    public static Vector3 tree2; 
    public static Vector3 tree3; 
    public static Vector3 tree4; 
    public static Vector3 pond_loc; 
    public static Vector3 puddle1_loc; 
    public static Vector3 puddle2_loc;
    public static Vector3 baby_fish_loc_1; // need to be put in pond 
    public static Vector3 adult_fish_loc_1;   
    public static Vector3 baby_fish_loc_2; // in pond
    public static Vector3 adult_fish_loc_2; 
    public static Vector3 rock_loc; 

    public static bool notPlacedAdult;
    public static bool notPlacedBaby;  

    private List<GameObject> plants;
    private GameObject[] rocks; 
    private GameObject pond, puddle1, puddle2, baby_fish, adult_fish;

    public const string front_plants = "front_plants"; 
    public int sortingOrder = 0; 
    private SpriteRenderer sprite; 

    // Start is called before the first frame update
    void Start()
    { 
            plants = new List<GameObject> {GameObject.FindWithTag("lily_purple"), GameObject.FindWithTag("lily_pink"), GameObject.FindWithTag("lily_orange"), 
                GameObject.FindWithTag("lily_blue"), GameObject.FindWithTag("daisy_blue"), GameObject.FindWithTag("daisy_orange"), 
                GameObject.FindWithTag("daisy_pink"), GameObject.FindWithTag("daisy_purple"),
                GameObject.FindWithTag("tree1"), GameObject.FindWithTag("tree2"), GameObject.FindWithTag("tree3"), GameObject.FindWithTag("tree4")}; 

            if ("3_Ponds_Scene" == SceneManager.GetActiveScene().name) {
                pond_loc = new Vector3(0, -1.75f, 0);
            } 
            
            if ("4_Koifish_Scene" == SceneManager.GetActiveScene().name || "5_Decorate_Scene" == SceneManager.GetActiveScene().name) {
                pond = GameObject.FindWithTag("FinishedPond"); 
                pond.transform.position = pond_loc;
            }

            if ("4_Koifish_Scene" == SceneManager.GetActiveScene().name) {
                puddle1 = GameObject.FindWithTag("puddle1");
                puddle2 = GameObject.FindWithTag("puddle2");
                adult_fish = GameObject.FindWithTag("adult_fish");
                baby_fish = GameObject.FindWithTag("baby_fish");

                if (pond_loc.x - 14 >= -18) {
                    puddle1.transform.position = new Vector3(pond_loc.x - 14, pond_loc.y, 0);
                    adult_fish.transform.position = new Vector3(pond_loc.x - 14, pond_loc.y, 0);
                }  else if (pond_loc.x - 10 >= -18) {
                    puddle1.transform.position = new Vector3(pond_loc.x - 10, pond_loc.y, 0);
                    adult_fish.transform.position = new Vector3(pond_loc.x - 10, pond_loc.y, 0);
                } else if (pond_loc.x - 5 >= -18) {
                    puddle1.transform.position = new Vector3(pond_loc.x - 5, pond_loc.y, 0);
                    adult_fish.transform.position = new Vector3(pond_loc.x - 5, pond_loc.y, 0);
                } else {
                    puddle1.transform.position = new Vector3(pond_loc.x + 28, pond_loc.y, 0);
                    adult_fish.transform.position = new Vector3(pond_loc.x + 28, pond_loc.y, 0);
                }

                if (pond_loc.x + 14 <= 18) {
                    puddle2.transform.position = new Vector3(pond_loc.x + 14, pond_loc.y, 0);
                    baby_fish.transform.position = new Vector3(pond_loc.x + 14, pond_loc.y, 0);
                } else if (pond_loc.x + 10 <= 18) {
                    puddle2.transform.position = new Vector3(pond_loc.x + 10, pond_loc.y, 0);
                    baby_fish.transform.position = new Vector3(pond_loc.x + 10, pond_loc.y, 0);
                } else if (pond_loc.x + 5 <= 18) {
                    puddle2.transform.position = new Vector3(pond_loc.x + 5, pond_loc.y, 0);
                    baby_fish.transform.position = new Vector3(pond_loc.x + 5, pond_loc.y, 0);
                } else {
                    puddle2.transform.position = new Vector3(pond_loc.x - 28, pond_loc.y, 0);
                    baby_fish.transform.position = new Vector3(pond_loc.x - 28, pond_loc.y, 0);   
                }
            }

            if ("5_Decorate_Scene" == SceneManager.GetActiveScene().name) {
                adult_fish = GameObject.FindWithTag("adult_fish");
                baby_fish = GameObject.FindWithTag("baby_fish");

                if (notPlacedAdult == true) {
                    adult_fish.SetActive(false);
                } else { 
                    adult_fish.transform.position = adult_fish_loc_2; 
                }

                if (notPlacedBaby == true) {
                    baby_fish.SetActive(false);
                } else { 
                    baby_fish.transform.position = baby_fish_loc_2; 
                }
            }

            foreach (GameObject plant in plants) {
                if (plant.tag == "daisy_orange") {
                    Debug.Log(orange_daisy); 
                    if (orange_daisy != new Vector3(0, 0, 0)) {
                        plant.transform.position = orange_daisy; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "daisy_pink") {
                    if (pink_daisy != new Vector3(0, 0, 0)) {
                        plant.transform.position = pink_daisy; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "daisy_blue") {
                    if (blue_daisy != new Vector3(0, 0, 0)) {
                        plant.transform.position= blue_daisy; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "daisy_purple") {
                    if (purple_daisy != new Vector3(0, 0, 0)) {
                        plant.transform.position = purple_daisy; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "lily_orange") {
                    if (orange_lily != new Vector3(0, 0, 0)) {
                        plant.transform.position = orange_lily; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "lily_pink") {
                    if (pink_lily != new Vector3(0, 0, 0)) {
                        plant.transform.position = pink_lily; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "lily_blue") {
                    if (blue_lily != new Vector3(0, 0, 0)) {
                        plant.transform.position = blue_lily; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "lily_purple") {
                    if (purple_lily != new Vector3(0, 0, 0)) {
                        plant.transform.position = purple_lily; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "tree1") {
                    if (tree1 != new Vector3(0, 0, 0)) {
                        plant.transform.position= tree1; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "tree2") {
                    if (tree2 != new Vector3(0, 0, 0)) {
                        plant.transform.position = tree2; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "tree3") {
                    if (tree3 != new Vector3(0, 0, 0)) {
                        plant.transform.position = tree3; 
                    } else {
                        plant.SetActive(false); 
                    }
                } else if (plant.tag == "tree4") {
                    if (tree4 != new Vector3(0, 0, 0)) {
                        plant.transform.position = tree4; 
                    } else {
                        plant.SetActive(false); 
                    }
                }

                // put this in plant seeds
                if (plant.transform.position.y < -1.2) { 
                    sprite = plant.GetComponent<SpriteRenderer>(); 
                    sprite.sortingOrder = sortingOrder; 
                    sprite.sortingLayerName = front_plants; 
                }
            }


        /*Debug.Log("Count " + invalidPlants.Count); 
        if (invalidPlants.Count > 0) {
            foreach(GameObject invalid in invalidPlants) {
                invalid.SetActive(false); 
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (pond_loc != new Vector3(0, -1.75f, 0)) { 
            foreach (GameObject plant in plants) {
                Debug.Log(plant.transform.position.x); 
                if ((plant.transform.position.x < pond_loc.x - 3.25) || (plant.transform.position.x > pond_loc.x + 3.25)) {
                    
                } else {
                    plant.SetActive(false); 
                }
            }
        }
    }
}
