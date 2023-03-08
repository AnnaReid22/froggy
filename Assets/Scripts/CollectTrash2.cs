using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrash2 : MonoBehaviour
{

     public Collider2D myCollider;

    void Start () {
        // this prevents all other colliders from messing with trash 
        // if clicking stops working or becomes buggy we probably need to ignore another layer
        Physics.IgnoreLayerCollision(0, 8);
        Physics.IgnoreLayerCollision(1, 8);
        Physics.IgnoreLayerCollision(2, 8);
        Physics.IgnoreLayerCollision(3, 8);
        Physics.IgnoreLayerCollision(4, 8);
        Physics.IgnoreLayerCollision(5, 8);
        Physics.IgnoreLayerCollision(6, 8);
        Physics.IgnoreLayerCollision(7, 8);
        Physics.IgnoreLayerCollision(8, 8); 
        Physics.IgnoreLayerCollision(9, 8);
        Physics.IgnoreLayerCollision(10, 8);

        myCollider = gameObject.GetComponent<Collider2D>();
    }

    public void Update () { 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)){ 
            if (myCollider == Physics2D.OverlapPoint(mousePos))
            {
                deactivate(); 
                Score.trash_score += 1;
                Debug.Log("Trash Score: " + Score.trash_score); // this is just so I can see that it is incrementing the score 
            }
        }
    }

    public void deactivate () {
        gameObject.SetActive(false); 
    }
}
