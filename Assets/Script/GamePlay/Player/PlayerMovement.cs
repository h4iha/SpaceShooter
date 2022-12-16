using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private void Awake()
    {
        speed = 10;
        rb = GetComponent<Rigidbody2D>();
    }
    public void DoMove(InputAction.CallbackContext callbackContext)
    {
        rb.velocity = new Vector2(callbackContext.ReadValue<Vector2>().x, callbackContext.ReadValue<Vector2>().y) * speed;
        //rb.MovePosition(transform.position + new Vector3(callbackContext.ReadValue<Vector2>().x, callbackContext.ReadValue<Vector2>().y));
    }
}
