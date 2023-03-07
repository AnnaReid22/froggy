using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
	public string sceneToLoad;
	public Button b;
	public Animator sunset;
	private bool setting = false;
    // Start is called before the first frame update
    void Start()
    {
		Button btn = b.GetComponent<Button>();
		sunset = GameObject.Find("Background_Wide").GetComponent<Animator>();
		btn.onClick.AddListener(transitionScene);
    }

    // Update is called once per frame
    void Update()
    {
		// logic to control that scene transition happens 
		// ONLY after the animation has completed once
		 if (sunset.GetCurrentAnimatorStateInfo(0).IsName("Sunset")) {
		 	setting = true;
		 }
		 if (!sunset.GetCurrentAnimatorStateInfo(0).IsName("Sunset") && setting)
		 {
		 	SceneManager.LoadScene(sceneToLoad);
			sunset.SetBool("run_sunset", false);
		 }
    }
	
	void transitionScene()
	{
		sunset.SetBool("run_sunset", true);
	}
}
