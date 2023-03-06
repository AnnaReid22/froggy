using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Froggy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        if (scene.name == "mailbox") {
            transform.position = new Vector3(0f, -1.46267f, 0); 
        }   
    }

    // Update is called once per frame
    void Update()
    {
        // if we add sound effects when Froggy collides with anything I would put it here 
    }
}
