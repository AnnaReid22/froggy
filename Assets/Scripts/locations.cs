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

    private List<GameObject> plants;

    // Start is called before the first frame update
    void Start()
    {
            plants = new List<GameObject> {GameObject.FindWithTag("lily_purple"), GameObject.FindWithTag("lily_pink"), GameObject.FindWithTag("lily_orange"), 
                GameObject.FindWithTag("lily_blue"), GameObject.FindWithTag("daisy_blue"), GameObject.FindWithTag("daisy_orange"), 
                GameObject.FindWithTag("daisy_pink"), GameObject.FindWithTag("daisy_purple"),
                GameObject.FindWithTag("tree1"), GameObject.FindWithTag("tree2"), GameObject.FindWithTag("tree3"), GameObject.FindWithTag("tree4")}; 

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
            }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
