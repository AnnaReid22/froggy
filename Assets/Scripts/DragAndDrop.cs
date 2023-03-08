using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code logic from: https://generalistprogrammer.com/game-design-development/unity-drag-and-drop-tutorial/
public class DragAndDrop : MonoBehaviour
{
    public bool canMove;
    public bool dragging;

    public Collider2D myCollider;
    
    void Start()
    {
        myCollider = gameObject.GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (myCollider == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                dragging = true;
            }
           

        }
        if (dragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMove = false;
            dragging = false;
        }
    }
}
