using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int damage;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
