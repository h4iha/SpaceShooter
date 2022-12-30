using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }
}
