using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public GameObject ControlsMenu;

    // Start is called before the first frame update
    void Start()
    {
        showMainMenu();
    }

    public void playGame()
    {
        // load first scene of game
        UnityEngine.SceneManagement.SceneManager.LoadScene("1_Trash_Scene");
    }

    public void showMainMenu()
    {
        // show main menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        ControlsMenu.SetActive(false);
    }

    public void showCredits()
    {
        // show credits menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void showControls()
    {
        // show controls screen
        MainMenu.SetActive(false);
        ControlsMenu.SetActive(true);
    }

    public void quitButton()
    {
        // quit game
        Application.Quit();
    }
}
