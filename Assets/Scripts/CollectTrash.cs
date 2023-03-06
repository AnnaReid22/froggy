using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrash : MonoBehaviour
{
    void OnMouseDown() {
        Destroy(gameObject); // if we decide we don't want to destory and just set inactive it would be this "gameObject.SetActive(false);"  
        Score.trash_score += 1;
        Debug.Log("Trash Score: " + Score.trash_score); // this is just so I can see that it is incrementing the score 
    }
}
