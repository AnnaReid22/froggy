using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour {

    public bool canMove;
    public bool dragging;
    Camera cam;
    public string objectName; 
    public AudioSource collectAudio;

    void Start() {
        // change all the 7s to 12s when we apply this to the trash layer (right now I'm testing in the plant layer)
        Physics.IgnoreLayerCollision(0, 9);
        Physics.IgnoreLayerCollision(1, 9);
        Physics.IgnoreLayerCollision(2, 9);
        Physics.IgnoreLayerCollision(3, 9);
        Physics.IgnoreLayerCollision(4, 9);
        Physics.IgnoreLayerCollision(5, 9);
        Physics.IgnoreLayerCollision(6, 9);
        Physics.IgnoreLayerCollision(7, 9); 
        Physics.IgnoreLayerCollision(9, 9); 
        Physics.IgnoreLayerCollision(12, 9);
        Physics.IgnoreLayerCollision(10, 9);

        Physics2D.IgnoreLayerCollision(0, 9);
        Physics2D.IgnoreLayerCollision(1, 9);
        Physics2D.IgnoreLayerCollision(2, 9);
        Physics2D.IgnoreLayerCollision(3, 9);
        Physics2D.IgnoreLayerCollision(4, 9);
        Physics2D.IgnoreLayerCollision(5, 9);
        Physics2D.IgnoreLayerCollision(6, 9);
        Physics2D.IgnoreLayerCollision(7, 9); 
        Physics2D.IgnoreLayerCollision(9, 9); 
        Physics2D.IgnoreLayerCollision(12, 9);
        Physics2D.IgnoreLayerCollision(10, 9);

        cam = Camera.main;
        if(SceneManager.GetActiveScene().name == "1_Trash_Scene")
        {
            collectAudio = GameObject.Find("positive_sound_froggy").GetComponent<AudioSource>();
        }
    }

    void Update() {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, 1 << 9); 

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

    void OnCollisionEnter2D(Collision2D other) {
        Score.trash_score += 1;
        Debug.Log("Trash Score: " + Score.trash_score);
        this.gameObject.SetActive(false);  
        collectAudio.Play();
    }
}
