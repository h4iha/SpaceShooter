using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private bool isItem;
    [SerializeField] private bool isLaser;
    private void OnTriggerStay2D(Collider2D other)
    {
        //if (other.tag == NameTag.Laser.ToString() && isLaser)
        //{
        //    Destroy(other.gameObject);
        //}
        //if (other.tag == TagLaser.Item.ToString() && isItem)
        //{
        //    Debug.Log(TagLaser.Item.ToString());
        //    Destroy(other.gameObject);
        //}
    }
}
