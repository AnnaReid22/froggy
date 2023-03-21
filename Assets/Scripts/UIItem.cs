using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// inspired and modified from https://medium.com/@yonem9/create-an-unity-inventory-part-4-display-items-in-ui-6cdac8f734b7

public class UIItem : MonoBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Item item;
    private Image image;
    public Camera cam;
    private UIItem selected; // selected item
    [HideInInspector] public Transform parentAfterDrag; // variable to unlink items from parent while dragging and relink after drag

    private void Awake()
    {
        image = GetComponent<Image>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        UpdateItem(null); // for testing
        selected = GameObject.Find("SelectedItem").GetComponent<UIItem>();
    }

    // function to determine whether to show or hide the item based on whether the player has it
    public void UpdateItem(Item item)
    {
        this.item = item;
        if(this.item != null)
        {
            image.color = Color.white;
            image.sprite = this.item.image;
        }
        else
        {
            image.color = Color.clear; // reset the alpha to 0 so the image is invisible
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // set initial item parent
        parentAfterDrag = transform.parent;
        // switch parent to canvas
        transform.SetParent(transform.root);
        // place item at top of view
        transform.SetAsLastSibling();
        // make item invisible to raycast during drag
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        // reset raycast target toggle
        image.raycastTarget = true;
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if(this.item != null)
        {
            if(selected.item != null)
            {
                // make a copy of the selected item
                Item copy = new Item(selected.item);
                selected.UpdateItem(this.item);
                // save item into inventory
                UpdateItem(copy);
            }
            else // if there was nothing selected before clicking
            {
                selected.UpdateItem(this.item);
                // clear inventory slot that item was on
                UpdateItem(null);
            }
        }
    }
}
