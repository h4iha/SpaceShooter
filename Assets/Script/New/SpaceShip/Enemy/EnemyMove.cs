using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float direction;
    private void Start()
    {
        speed = 5f;
    }
    void Update()
    {
        if (transform.position.x <= 0f) return;
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
