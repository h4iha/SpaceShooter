using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounted : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    private void Update()
    {
        //Debug.Log("LateUpdate" + transform.childCount);
        if (transform.childCount == 0)
        {

        }
    }
}
