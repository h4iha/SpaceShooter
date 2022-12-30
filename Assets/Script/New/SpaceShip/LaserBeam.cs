using UnityEngine;

public class LaserBeam : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    private int damage;
    public Sprite SetSprite { set { spriteRenderer.sprite = value; } }
    public int SetDamage { set { damage = value; } }
    public int GetDamage { get { return damage; } }
}
