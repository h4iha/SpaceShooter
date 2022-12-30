using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PrefabDrawing : MonoBehaviour
{
    private PolygonCollider2D polygonCollider;
    public void UpdatePolygon2D(bool isTrigger)
    {
        polygonCollider = this.GetComponent<PolygonCollider2D>();
        if (polygonCollider != null)
        {
            Destroy(polygonCollider);
        }
        this.AddComponent<PolygonCollider2D>().isTrigger = isTrigger;
    }
}
