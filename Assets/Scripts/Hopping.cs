using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hopping : MonoBehaviour
{
    
    public float speed = 1f; 
    public float horizontalMove = 0f; 

    void Update()
    {
        horizontalMove = speed * Input.GetAxisRaw("Horizontal");
        gameObject.GetComponent<Animator>().SetFloat("speed", Mathf.Abs(horizontalMove));
    }

    private void FixedUpdate() { 
        transform.Translate(Vector3.right * Time.fixedDeltaTime * horizontalMove);
    }
}
