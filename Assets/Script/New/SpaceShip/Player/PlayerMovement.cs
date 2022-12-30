using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float maxX;
    [SerializeField] private float maxY;
    private void Update()
    {
        float x = Mathf.Clamp(transform.position.x, -maxX, maxX);
        float y = Mathf.Clamp(transform.position.y, -(maxY+1), maxY);
        transform.position = new Vector2(x, y);
    }
    public void DoMove(InputAction.CallbackContext callbackContext)
    {
        float xAis = callbackContext.ReadValue<Vector2>().x;
        float yAis = callbackContext.ReadValue<Vector2>().y;
        rb.velocity = new Vector2(xAis, yAis) * speed;
    }
}
