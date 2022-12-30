using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour
{
    [SerializeField] private Text text;
    private int pauseValue;
    private void Start()
    {
        pauseValue = 1;
        text.text = "PAUSE";
    }
    public void DoPauseOrUnpause()
    {
        if (pauseValue == 1)
        {
            text.text = "UNPAUSE";
            pauseValue = 0;
        }
        else
        {
            text.text = "PAUSE";
            pauseValue = 1;
        }
        Time.timeScale = pauseValue;
    }
}
