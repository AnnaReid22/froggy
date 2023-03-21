using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// inspired and modified from https://medium.com/@yonem9/create-an-unity-inventory-part-5-drag-and-drop-d4374201539b

public class ItemMouseFollow : MonoBehaviour
{
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
       transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }
}
