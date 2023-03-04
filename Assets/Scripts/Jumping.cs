using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    
    public float speed = 1f; 
    public float horizontalMove = 0f; 

    // Update is called once per frame
    void Update()
    {
        horizontalMove = speed * Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(horizontalMove) > 0) { 
            gameObject.GetComponent<Animator>().SetBool("jump", true);
        } else {
            gameObject.GetComponent<Animator>().SetBool("jump", false);
        }
    }

    private void FixedUpdate() { 
        transform.Translate(Vector3.right * Time.fixedDeltaTime * horizontalMove);
    }
}
