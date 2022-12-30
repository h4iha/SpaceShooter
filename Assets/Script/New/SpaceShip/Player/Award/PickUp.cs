using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum AwardType
{
    Heart,
    Laser,
    Shield
}
public class PickUp : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Award item;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.tag == TagLaser.Item.ToString())
        //{
        //    if (other.GetComponent<Award>().Type == AwardType.Heart && gameManager.CurrentHearts < gameManager.MaxHearts)
        //    {
        //        gameManager.CurrentHearts++;
        //        Destroy(other.gameObject);
        //    }
        //    if (other.GetComponent<Award>().Type == AwardType.Laser && gameManager.CurrentLevelLaser < gameManager.MaxLevelLaser)
        //    {
        //        detail.IncreateLevel(true);
        //        Destroy(other.gameObject);

        //    }
        //    if (other.GetComponent<Award>().Type == AwardType.Shield && gameManager.CurrentLevelShield < gameManager.MaxLevelShield)
        //    {
        //        detail.IncreateLevel(false);
        //        Destroy(other.gameObject);
        //    }
        //}
    }
}
