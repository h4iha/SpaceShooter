using System;
using UnityEngine;

public class ShieldSpaceShip : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private int maxShield;
    private HealthSystem shield;
    public Action<int> onChangeValueShield;
    private void Awake()
    {
        shield = new HealthSystem(maxShield, 1, HandleDeath);
        shield.ReceiDamage();

    }
    private void OnEnable()
    {
        onChangeValueShield?.Invoke(shield.GetHitPoint);
        shield.Heal();
    }
    private void OnDisable()
    {
        onChangeValueShield?.Invoke(shield.GetHitPoint);
    }
    private void HandleDeath()
    {
        this.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string laserTag = TagLaserBeam.Enemy.ToString();
        if (collision.CompareTag(laserTag))
        {
            shield.ReceiDamage();
        }
    }
    public void IncreaseLevelShield()
    {
        shield.Heal();
        onChangeValueShield?.Invoke(shield.GetHitPoint);
    }
}
