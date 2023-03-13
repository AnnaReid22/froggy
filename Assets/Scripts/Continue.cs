using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
	public Button b;
    // Start is called before the first frame update
    void Start()
    {
		Button btn = b.GetComponent<Button>();
		btn.onClick.AddListener(continueGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void continueGame()
	{
		SceneManager.LoadScene("1_Trash_Scene");
	}
}
