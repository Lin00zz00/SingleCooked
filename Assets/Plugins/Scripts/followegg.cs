using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followegg : MonoBehaviour
{
    public Transform target ;
    // Start is called before the first frame update
    private void Start()
    {
       StartCoroutine(DelayForFollow()); 
    }

    // Update is called once per frame
    private void OnDisable()
    {
         StopAllCoroutines();
    }
    private IEnumerator DelayForFollow()
    {
        WaitForSeconds waitTime = new(0.2f);
        while (true)
        {
           yield return waitTime ;
           transform .position = target .position ;
        }
    }
}
