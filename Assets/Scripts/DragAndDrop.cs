using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    public bool canMove;
    public bool dragging;
    Camera cam;
    public string objectName; 

    void Start() {
        // change all the 7s to 12s when we apply this to the trash layer (right now I'm testing in the plant layer)
        Physics.IgnoreLayerCollision(0, 7);
        Physics.IgnoreLayerCollision(1, 7);
        Physics.IgnoreLayerCollision(2, 7);
        Physics.IgnoreLayerCollision(3, 7);
        Physics.IgnoreLayerCollision(4, 7);
        Physics.IgnoreLayerCollision(5, 7);
        Physics.IgnoreLayerCollision(6, 7);
        Physics.IgnoreLayerCollision(12, 7);
        Physics.IgnoreLayerCollision(10, 7);

        cam = Camera.main;
    }

    void Update() {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, 1 << 7); 

            if (hit.collider != null)
            {
                canMove = true;
                objectName = hit.collider.name; 
            }
            else
            {
                canMove = false;
            }
            
            if (canMove)
            {
                dragging = true;
            }

            if (hit.collider.name == "") {
            }

        }

        if (dragging) {
            if (objectName == gameObject.name) {
                this.transform.position = mousePos;
            }
        }

        if (Input.GetMouseButtonUp(0)) {
            canMove = false;
            dragging = false;
        }
    }
}
