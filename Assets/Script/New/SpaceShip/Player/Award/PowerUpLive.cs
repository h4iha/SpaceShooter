using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpLive : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
        // spriteRenderer.sprite = gameManager.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagCharacter.Player.ToString()))
        {
            other.GetComponent<PlayerSpaceShip>().PickUpLive();
        }
    }
}
