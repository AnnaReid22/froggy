using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// not currently being used
public class CollectTrash : MonoBehaviour
{

    //public Collider2D myCollider;
    Camera cam; 
    public Collider2D myCollider;
	public AudioSource collectAudio;


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
        //Physics.IgnoreLayerCollision(12, 12); 
        Physics.IgnoreLayerCollision(10, 12);

        //myCollider = gameObject.GetComponent<Collider2D>();
        cam = Camera.main; 
    }

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, 1 << 12); 
            //RaycastHit2D hit  = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);

            
            if (hit.collider != null) {
                //if (hit.collider.gameObject.layer == 12) {
                    hit.collider.gameObject.SetActive(false); 
                    Score.trash_score += 2;
                    Debug.Log("Trash Score: " + Score.trash_score);
					collectAudio.Play();
                //}
            }
        }
    }

    /*public void OnMouseDown() {
        //deactivate(); 
        Score.trash_score += 1;
        Debug.Log("Trash Score: " + Score.trash_score); // this is just so I can see that it is incrementing the score   
    }*/

    //public void deactivate () {
      //  gameObject.SetActive(false); 
    //}
}
