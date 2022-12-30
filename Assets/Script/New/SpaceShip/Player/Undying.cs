using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undying : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRendererPlayer;
    private bool isFlash;
    private int time;
    private void OnEnable()
    {
        time = 1;
        isFlash = true;
        CooldownFlash();
    }
    private IEnumerator CooldownFlash()
    {
        if (time == 20)
        {
            this.gameObject.SetActive(false);
            yield break;
        }
        isFlash = !isFlash;
        spriteRendererPlayer.enabled = isFlash;
        yield return new WaitForSeconds(0.1f);
        time++;
        CooldownFlash();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tagLaser = TagLaserBeam.Enemy.ToString();
        if (collision.CompareTag(tagLaser))
        {
            Destroy(collision.gameObject);
        }
    }
}
