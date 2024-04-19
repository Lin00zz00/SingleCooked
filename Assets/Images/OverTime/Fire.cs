using System.Collections;
using UnityEngine;

public class AddOillement : MonoBehaviour
{
    public GameObject fireElement; // 引用 FireElement 元素
    private bool hasTimerStarted = false;

    private void OnBecameVisible()
    {
        if (!hasTimerStarted)
        {
            // 开始计时器，等待15秒后显示 FireElement
            StartCoroutine(ShowFireAfterDelay(16));
            hasTimerStarted = true;
        }
    }

    private IEnumerator ShowFireAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // 15秒后执行的逻辑
        if (fireElement != null)
        {
            // 将 FireElement 设为可见
            fireElement.SetActive(true);
        }
    }

    private void OnBecameInvisible()
    {
        // 当 AddOilElement 不可见时，停止计时器并将 FireElement 设为不可见
        StopAllCoroutines();
        if (fireElement != null)
        {
            fireElement.SetActive(false);
        }
    }
}
