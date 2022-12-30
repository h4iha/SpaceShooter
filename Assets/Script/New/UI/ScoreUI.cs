using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
        ShowScore(gameManager.CurrentScores);
    }
    private void Update()
    {
        ShowScore(gameManager.CurrentScores);
    }
    private void ShowScore(int totalScore)
    {
        int numberOfZeros = 9 - totalScore.ToString().Length;
        string numberOfZerosToShow = "";
        for (int i = 0; i < numberOfZeros; i++)
        {
            numberOfZerosToShow += "0";
        }
        scoreText.text = numberOfZerosToShow + totalScore.ToString();
    }
}
