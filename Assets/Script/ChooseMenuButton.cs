using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public enum NameColor
{
    Red,
    Green,
    Blue,
    Orange,
}
public class ChooseMenuButton : MonoBehaviour
{
    //private NameColor nameColor;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject chooseMenu;
    [SerializeField] private int indexCurrentFighterJet;
    [SerializeField] private int indexType;
    [SerializeField] private int indexColor;
    [SerializeField] private string[] nameColor;
    [SerializeField] private Image image;
    [SerializeField] private GameObject selectedGameObject;
    public void Awake()
    {
        //string name = NameColor.Red.DisplayName();
        nameColor = new string[] { "Red", "Green", "Blue", "Orange"};
        indexColor = 0;
        indexType = 0;
        SetSpriteCurrentFighterJet();

    }
    public void ChangeColor()
    {
        Change(ref indexColor, 2);
        SetSpriteCurrentFighterJet();
    }
    public void ChangeType()
    {
        Change(ref indexType, 2);
        SetSpriteCurrentFighterJet();
    }
    public void StartGame()
    {
        chooseMenu.SetActive(false);
        mainMenu.SetActive(false);
    }
    public void BackToMainMenu()
    {
        chooseMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    private void Change(ref int index, int maxindex)
    {
        if (index < maxindex)
        {
            index++;
        }
        else
        {
            index = 0;
        }
    }
    private void SetSpriteCurrentFighterJet()
    {
        //indexCurrentFighterJet = indexColor * 3 + indexType;
        string name = "jet" + nameColor[indexColor] + "0" + (indexType + 1).ToString();
        Debug.Log(name);
        image.sprite = Resources.Load<Sprite>("Player/" + name);
    }
}
