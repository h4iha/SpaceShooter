using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DrawCollider : MonoBehaviour
{
    public void DoDestroyCollider()
    {
        PolygonCollider2D polygonCollider = this.GetComponent<PolygonCollider2D>();
        Destroy(polygonCollider);
    }
    public void DoAddCollider()
    {
        this.AddComponent<PolygonCollider2D>();
    }
    public PolygonCollider2D DoAddColliderAndReturn()
    {
        return this.AddComponent<PolygonCollider2D>();
    }
}
