using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
	public static int trash_score = 0;
	public static int max_room_score = 20;
	public static int planting_score = 0;
	public static int pond_score = 0;
	public static int koifish_score = 0;
	public static int decorations_score = 0;
	public TMP_Text result;
	
	private float max_total_score = 100.0f;
	
	public static float total_score = 0.0f;
	
	void Start()
	{
	}
	
	    // Update is called once per frame
    void Update()
    {
		if ("6_Score_Scene" == SceneManager.GetActiveScene().name)
		{
			Debug.Log("planting_score: " + planting_score); 
			Debug.Log("trash_score: " + trash_score);
			Debug.Log("pond_score: " + pond_score);
			Debug.Log("koifish_score: " + koifish_score); 
			Debug.Log("decorations_score: " + decorations_score); 

			total_score = (trash_score + planting_score + pond_score + koifish_score + decorations_score) / max_total_score;
			result.text = "Your Score is " + total_score.ToString();
			
		}
		else
		{
			total_score = 0.0f;
		}
    }
	


}
