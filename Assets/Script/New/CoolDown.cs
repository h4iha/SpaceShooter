using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDown : MonoBehaviour
{
    [SerializeField] private bool isRuning;
    public Action onCoolDown;

 
    public void WaitForCoolDown(float timeCoolDown)
    {
        if (!isRuning)
        {
            isRuning = true;
            StartCoroutine(WaitCouroutime(timeCoolDown));
        }
    }
    IEnumerator WaitCouroutime(float timeCoolDown)
    {
        yield return new WaitForSeconds(timeCoolDown);
        isRuning = false;
        onCoolDown?.Invoke();
    }
}
