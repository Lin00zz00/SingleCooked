using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class scallions : MonoBehaviour
{
    Animator animator;
    private DOTweenAnimation tweenAnimation;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        tweenAnimation=GetComponent<DOTweenAnimation>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetTrigger("changesca");
        }
    }
}
