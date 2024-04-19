using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowText : MonoBehaviour
{
    public Transform target;
    private void Start()
    {
        StartCoroutine(DelayForFollow());

    }

    private void onDisable()
    {
        StopAllCoroutines();
    }
    private IEnumerator DelayForFollow()
    {
        WaitForSeconds waitTime = new(0.01f);
        while (true)
        {
            yield return waitTime;

            transform.position=target.position;
    
    
        }
    }

    
}
