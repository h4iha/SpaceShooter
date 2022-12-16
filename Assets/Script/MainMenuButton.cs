using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject chooseMenu;
    public void ChangeToChooseMenu()
    {
        mainMenu.SetActive(false);
        chooseMenu.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
