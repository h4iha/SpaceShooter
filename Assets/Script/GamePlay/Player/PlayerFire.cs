using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private CoolDown coolDown;
    [SerializeField] private float rateOfFire;
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private bool isCanFire;
    [SerializeField] private Sprite sprite;
    [SerializeField] private int damage;
    private void Awake()
    {
        isCanFire = true;
        rateOfFire = 4;
        coolDown = this.GetComponent<CoolDown>();
    }
    private void Start()
    {
        coolDown.onCoolDown += CoolDownComplete;
    }
    public void DoFireForPlayer(InputAction.CallbackContext _)
    {
        if (isCanFire)
        {
            isCanFire = false;
            GameObject newLaser = Instantiate(laserPrefab, new Vector2(this.transform.position.x, this.transform.position.y + 0.5f), Quaternion.identity);
            FireLaser(ref newLaser);
            coolDown.WaitForCoolDown(1 / rateOfFire);
        }
    }
    private void CoolDownComplete()
    {
        isCanFire = true;
    }
    private void FireLaser(ref GameObject gameObject)
    {
        // Tao hinh dang va damage cho Laser
        Laser laser = gameObject.GetComponent<Laser>();
        laser.spriteRenderer.sprite = sprite;
        laser.damage = damage;
        // ve lai collider
        DrawCollider drawCollider = gameObject.GetComponent<DrawCollider>();
        drawCollider.DoDestroyCollider();
        // set trigger cho collider
        PolygonCollider2D polygonCollider2D = drawCollider.DoAddColliderAndReturn();
        polygonCollider2D.isTrigger = true;
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        // tao luc de ban laser
        rigidbody2D.AddForce(new Vector2(0, 100));
    }
}
