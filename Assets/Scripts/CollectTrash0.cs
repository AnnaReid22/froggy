using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrash0 : MonoBehaviour
{

    public Collider2D myCollider;

    void Start () {
        // this prevents all other colliders from messing with trash 
        // if clicking stops working or becomes buggy we probably need to ignore another layer
        Physics.IgnoreLayerCollision(0, 12);
        Physics.IgnoreLayerCollision(1, 12);
        Physics.IgnoreLayerCollision(2, 12);
        Physics.IgnoreLayerCollision(3, 12);
        Physics.IgnoreLayerCollision(4, 12);
        Physics.IgnoreLayerCollision(5, 12);
        Physics.IgnoreLayerCollision(6, 12);
        Physics.IgnoreLayerCollision(7, 12);
        Physics.IgnoreLayerCollision(12, 12); 
        Physics.IgnoreLayerCollision(10, 12);

        myCollider = gameObject.GetComponent<Collider2D>();
    }

    public void Update () { 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) { 
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
