using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code logic from: https://generalistprogrammer.com/game-design-development/unity-drag-and-drop-tutorial/
public class DragAndDrop : MonoBehaviour
{
    // The plane the object is currently being dragged on
    //Plane dragPlane;

    // The difference between where the mouse is on the drag plane and 
    // where the origin of the object is on the drag plane
    //Vector3 offset;
    public bool canMove;
    public bool dragging;
    Camera cam;

    void Start() {
        cam = Camera.main;
    }

    void Update() {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, 1 << 7); 
            //RaycastHit2D hit  = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);

            
            /*if (hit.collider != null) {
                //if (hit.collider.gameObject.layer == 12) {
                    hit.collider.gameObject.SetActive(false); 
                    Score.trash_score += 1;
                    Debug.Log("Trash Score: " + Score.trash_score);
                //}
            }*/

            if (hit.collider == Physics2D.OverlapPoint(mousePos))
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

        if (dragging) {
            this.transform.position = mousePos;
        }

        if (Input.GetMouseButtonUp(0)) {
            canMove = false;
            dragging = false;
        }
    }

    /*void OnMouseDown() {

        dragPlane = new Plane(cam.transform.forward, transform.position);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(ray, out planeDist);
        offset = transform.position - ray.GetPoint(planeDist);
    }

    void OnMouseDrag() {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(ray, out planeDist);
        transform.position = ray.GetPoint(planeDist) + offset;
    }*/
    
    /*public bool canMove;
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
    }*/
}
