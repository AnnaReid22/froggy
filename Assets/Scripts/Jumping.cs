using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public float force = 8; // height of jump 
    public float gravityScale = 2;
    public float fallingGravityScale = 10; // how fast we fall back down 

    public Transform groundCheck; 
    public LayerMask groundLayer; 

    bool isGrounded;

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) { 
            if (isGrounded) { // this if statement prevents double jumping 
                gameObject.GetComponent<Animator>().SetBool("jump", true); // set animation variable 
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * force;   // jump up 
            }
        }

        // change gravity for jumping up and falling down 
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y >= 0)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = gravityScale;
        }
        else if (gameObject.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = fallingGravityScale;
        }
    }

    private void FixedUpdate() { 
        // detect if the player is not on the ground and change the animation to no longer jumping up 
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 1f, groundLayer);

        if (!isGrounded) { 
            gameObject.GetComponent<Animator>().SetBool("jump", true);
        } else if (isGrounded) { 
            gameObject.GetComponent<Animator>().SetBool("jump", false);
        }
    }
}
