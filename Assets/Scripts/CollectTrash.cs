using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrash : MonoBehaviour
{
    Camera cam; 
    public Collider2D myCollider;


    void Start () {
        Physics.IgnoreLayerCollision(0, 12);
        Physics.IgnoreLayerCollision(1, 12);
        Physics.IgnoreLayerCollision(2, 12);
        Physics.IgnoreLayerCollision(3, 12);
        Physics.IgnoreLayerCollision(4, 12);
        Physics.IgnoreLayerCollision(5, 12);
        Physics.IgnoreLayerCollision(6, 12);
        Physics.IgnoreLayerCollision(7, 12);
        Physics.IgnoreLayerCollision(10, 12);

        cam = Camera.main; 
    }

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, 1 << 12); 

            
            if (hit.collider != null) {
                    hit.collider.gameObject.SetActive(false); 
                    Score.trash_score += 1;
                    Debug.Log("Trash Score: " + Score.trash_score);
            }
        }
    }
}
