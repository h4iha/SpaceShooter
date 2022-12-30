using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField] private float timer = 0;
    private void Start()
    {
        StartCoroutine(CountDown());
    }
    private IEnumerator CountDown()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
