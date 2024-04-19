using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentTrigger : MonoBehaviour
{
    public GameObject chopTomatoesElement; // 指向 "ChopTomatoes" 元件
    private Animator animator; // 元件上的 Animator 组件
    private bool triggerActivated = false; // 标志是否已触发过 Trigger

    void Start()
    {
        // 获取元件上的 Animator 组件
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 检测 "ChopTomatoes" 元件是否激活，并且触发状态为 false
        if (chopTomatoesElement.activeSelf && !triggerActivated)
        {
            // 当 "ChopTomatoes" 元件出现且触发状态为 false 时，触发 "walk" Trigger
            animator.SetTrigger("walk");
            triggerActivated = true; // 设置触发状态为 true，避免重复触发
            Debug.Log("Walk animation triggered."); // 添加打印指令
        }
    }
}
