using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMainMenu : MonoBehaviour
{
    public void backToMenu() { 
        // reset the scores, return to the main menu 
        SceneManager.LoadScene(0); 
        Score.trash_score = 0;
        Score.planting_score = 0;
        Score.pond_score = 0;
        Score.koifish_score = 0;
        Score.decorations_score = 0;
        Score.total_score = 0.0f;
    }
}
