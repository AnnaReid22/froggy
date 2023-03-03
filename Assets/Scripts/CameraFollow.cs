using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player; // froggy
    public BoxCollider2D map; // bounds of entire background

    private float minX, minY, maxX, maxY, newCamX, newCamY; // min and max x and y for camera to be bound within
    private Camera cam; //  camera object
    private float camSize; // camera size
    private float camRatio; // camera ratio

    void Start()
    {
        // populate values at start of script
        cam = GetComponent<Camera>();
        map = GameObject.FindWithTag("Map").GetComponent<BoxCollider2D>(); // get object that represents map
        minX = map.bounds.min.x;
        minY = map.bounds.min.y;
        maxX = map.bounds.max.x;
        maxY = map.bounds.max.y;

        camSize = cam.orthographicSize;
        camRatio = camSize * (16/9); // because we chose 16:9 aspect ratio
    }

    void Update()
    {
        // get current active player in scene
        player = GameObject.FindWithTag("Player").transform;
        // get camera position based on players position in this frame
        newCamY = Mathf.Clamp(player.position.y, minY + camSize, maxY - camSize);
        newCamX = Mathf.Clamp(player.position.x, minX + camRatio, maxX - camRatio);
        // move camera to follow player
        this.transform.position = new Vector3(newCamX, this.transform.position.y, this.transform.position.z);
    }
}
