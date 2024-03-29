using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Froggy : MonoBehaviour
{

	public GameObject pond;
	
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene(); // get current scene name 
        if (scene.name == "1_Trash_Scene") { 
            // set starting position in the trash scene
            transform.position = new Vector3(0f, -1.46267f, 0); 
        }
		if (scene.name == "4_Koifish_Scene") { 
            // set starting position in the trash scene
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), pond.GetComponent<Collider2D>());
        }   
    }

    void Update()
    {
        // if we add sound effects when Froggy collides with anything I would put it here 
    }
}
