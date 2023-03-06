using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hopping : MonoBehaviour
{
    
    public float speed = 1f; 
    public float horizontalMove = 0f; 

    void Update()
    {
        horizontalMove = speed * Input.GetAxisRaw("Horizontal"); // arrow key movement
        gameObject.GetComponent<Animator>().SetFloat("speed", Mathf.Abs(horizontalMove)); // set animation variable 
    }

    private void FixedUpdate() { 
        transform.Translate(Vector3.right * Time.fixedDeltaTime * horizontalMove); // arrow key movement 
    }
}
