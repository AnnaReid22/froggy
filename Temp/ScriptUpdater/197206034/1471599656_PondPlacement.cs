using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondPlacement : MonoBehaviour
{
    public GameObject[] rocks; // list of rock objects in the scene
    public GameObject bucket; // water bucket to trigger completed pond
    public GameObject pond; // finished pond object, initially not active in scene
    public float[] centerCoord; // coordinates of center of finished pond

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        rocks = GameObject.FindGameObjectsWithTag("Rock");
        pond = GameObject.FindWithTag("FinishedPond");
        bucket = GameObject.FindWithTag("Bucket");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Updating...");
        centerCoord = FindPondCenter();
        if (bucket.transform.position.y < 0)
        {
            Debug.Log("Starting to build pond...");
            foreach (GameObject rock in rocks)
            {
                rock.SetActive(false);
            }
            this.transform.position = new Vector2(centerCoord[0], centerCoord[1]);
            this.GetComponent<Renderer>().enabled = true;
        }
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
        Debug.Log("Center X: " + center[0]);
        Debug.Log("Center Y: " + center[1]);

        return center;
    }
}
