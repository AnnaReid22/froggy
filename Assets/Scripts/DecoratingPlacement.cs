using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratingPlacement : MonoBehaviour
{
	public GameObject displayText;
	public AudioSource a;
	private Inventory inventory; // player inventory
	private bool played = false;
    // Start is called before the first frame update
    void Start()
    {
		inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        // give decorating items to player
        inventory.GiveItem("chair");
		inventory.GiveItem("fence");
		inventory.GiveItem("pot1");
		inventory.GiveItem("pot2");
		inventory.GiveItem("shovel");
		inventory.GiveItem("table");
		
		a = GameObject.Find("max_score").GetComponent<AudioSource>();
		GameObject canvas = GameObject.Find("Canvas");
		displayText = canvas.transform.Find("Text (TMP) (1)").gameObject;
		displayText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		int objectsInScene = 0;
        if(GameObject.FindWithTag("chair") != null)
		{
			objectsInScene += 1;
		}
		if(GameObject.FindWithTag("fence") != null)
		{
			objectsInScene += 1;
		}
		if(GameObject.FindWithTag("pot1") != null)
		{
			objectsInScene += 1;
		}
		if(GameObject.FindWithTag("pot2") != null)
		{
			objectsInScene += 1;
		}
		if(GameObject.FindWithTag("shovel") != null)
		{
			objectsInScene += 1;
		}
		if(GameObject.FindWithTag("table") != null)
		{
			objectsInScene += 1;
		}
		
		if(objectsInScene == 6)
		{
			Score.decorations_score = 6;
			if(Score.decorations_score >= Score.max_decorations_score)
			{
				displayText.SetActive(true);
				if (!played)
				{
					a.Play();
					played = true;
				}
				
			}
			else
			{
				displayText.SetActive(false);
			}
		}
		else if(objectsInScene == 5)
		{
			Score.decorations_score = 5;
			played = false;
		}
		else if(objectsInScene == 4)
		{
			Score.decorations_score = 4;
			played = false;
		}
		else if(objectsInScene == 3)
		{
			Score.decorations_score = 3;
			played = false;
		}
		else if(objectsInScene == 2)
		{
			Score.decorations_score = 2;
			played = false;
		}
		else if(objectsInScene == 1)
		{
			Score.decorations_score = 1;
			played = false;
		}
		else if(objectsInScene == 0)
		{
			Score.decorations_score = 0;
			played = false;
		}
		
    }
}
