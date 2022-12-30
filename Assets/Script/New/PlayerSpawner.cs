using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = GameManager.Instance;
    }
}
