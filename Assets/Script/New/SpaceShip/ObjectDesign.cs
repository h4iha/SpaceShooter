using Unity.VisualScripting;
using UnityEngine;

public class ObjectDesign : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    private Sprite objectSprite;
    private PolygonCollider2D polygonCollider;
    public void UpdatePolygon2D()
    {
        spriteRenderer.sprite = objectSprite;
        polygonCollider = this.GetComponent<PolygonCollider2D>();
        if (polygonCollider != null)
        {
            Destroy(polygonCollider);
        }
        this.AddComponent<PolygonCollider2D>().isTrigger = true;
    }
}
