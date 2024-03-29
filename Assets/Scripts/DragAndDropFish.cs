using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DragAndDropFish : MonoBehaviour {

	public AudioSource a;
	public GameObject displayText;
    public bool canMove;
    public bool dragging;
    Camera cam;
    public string objectName; 
    public AudioSource goodAudio;
	public AudioSource badAudio;

    void Start() {
		displayText.SetActive(false);

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

        locations.notPlacedAdult = true;
        locations.notPlacedBaby = true;  
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
            if (this.tag == "baby_fish") { 
                locations.baby_fish_loc_2 = this.transform.position; 
            } else if (this.tag == "adult_fish") {
                locations.adult_fish_loc_2 = this.transform.position;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (this.tag == "baby_fish") { 
            locations.notPlacedBaby = false; 
        } else if (this.tag == "adult_fish") {
            locations.notPlacedAdult = false; 
        }
        Score.koifish_score += 10;
        Debug.Log("Koi Score Up: " + Score.koifish_score);
        goodAudio.Play();
		if (Score.koifish_score == Score.max_koifish_score)
		{
			a.Play();
			displayText.SetActive(true);
		}
    }
	
	void OnCollisionExit2D(Collision2D col)
	{
        if (this.tag == "baby_fish") { 
            locations.notPlacedAdult = true; 
        } else if (this.tag == "adult_fish") {
            locations.notPlacedBaby = true; 
        } 
		Score.koifish_score -= 10;
		displayText.SetActive(false);
		Debug.Log("Koi Score Down: " + Score.koifish_score);
		badAudio.Play();
	}
}
