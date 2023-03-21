using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondPlacement : MonoBehaviour
{
	public GameObject displayText;
	public AudioSource a;
    public GameObject[] rocks; // list of rock objects in the scene
    public GameObject bucket; // water bucket to trigger completed pond
    public GameObject pond; // finished pond object, initially not active in scene
    private Renderer pondImage; // sprite renderer of the completed pond
    public float[] centerCoord; // coordinates of center of finished pond
    private Inventory inventory; // player inventory

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        // give bucket item to player
        inventory.GiveItem("Water Bucket");

        pondImage = this.GetComponent<Renderer>();
        pondImage.enabled = false;
        rocks = GameObject.FindGameObjectsWithTag("Rock");
        pond = GameObject.FindWithTag("FinishedPond");
		a = GameObject.Find("max_score").GetComponent<AudioSource>();
		GameObject canvas = GameObject.Find("Canvas");
		displayText = canvas.transform.Find("Text (TMP) (1)").gameObject;
		displayText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bucket = GameObject.FindWithTag("Bucket");
        // update rocks list
        rocks = GameObject.FindGameObjectsWithTag("Rock");

        if (bucket != null && bucket.transform.position.y < 0)
        {
            Score.pond_score = GetScore(rocks);
			if(Score.pond_score >= Score.max_room_score)
			{
				a.Play();
				displayText.SetActive(true);
			}
			else
			{
				displayText.SetActive(false);
			}
            centerCoord = FindPondCenter();
            foreach (GameObject rock in rocks)
            {
                rock.SetActive(false);
            }
            this.transform.position = new Vector3(centerCoord[0], centerCoord[1], 0);
            locations.pond_loc = this.transform.position; 
            pondImage.enabled = true;
            bucket.SetActive(false);
        }
    }

    public int GetScore(GameObject[] rocks)
    {
        int score = 20; // total possible score

        foreach (GameObject rock1 in rocks)
        {
            int colliderCount = 0;
            PolygonCollider2D collider1 = rock1.GetComponent<PolygonCollider2D>();
            foreach (GameObject rock2 in rocks)
            {
                if (rock1 == rock2){continue;}
                
                PolygonCollider2D collider2 = rock2.GetComponent<PolygonCollider2D>();

                if(collider1.bounds.Intersects(collider2.bounds))
                {
                    colliderCount++;
                }
            }
            if(colliderCount == 0)
            {
                score -= 2;
            }
            if(colliderCount == 1)
            {
                score -= 1;
            }
        }
        Debug.Log("score: " + score);
        return score;
    }

    public float[] FindPondCenter() // get the center coordinates of the rock configuration
    {
        float[] center = new float[2]; // coordinates
        float xMin,xMax,yMin,yMax; // min and max x and y values of rocks to compute approx. center

        // initialize min and max values to compare against in loop
        xMin = rocks[0].transform.position.x;
        xMax = rocks[1].transform.position.x;
        yMin = rocks[0].transform.position.y;
        yMax = rocks[1].transform.position.y;
        foreach (GameObject rock in rocks)
        {
            if (rock.transform.position.x < xMin)
            {
                xMin = rock.transform.position.x;
            }
            if (rock.transform.position.x > xMax)
            {
                xMax = rock.transform.position.x;
            }
            if (rock.transform.position.y < yMin)
            {
                yMin = rock.transform.position.y;
            }
            if (rock.transform.position.y > yMax)
            {
                yMax = rock.transform.position.y;
            }
        }

        center[0] = ((xMax - xMin)/2) + xMin;
        center[1] = ((yMax - yMin)/2) + yMin;

        return center;
    }
}
