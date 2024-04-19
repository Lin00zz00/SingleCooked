using System.Collections;
using UnityEngine;

public class ScallionEOillement : MonoBehaviour
{
    public GameObject fire2Element; // 引用 FireElement 元素
    private bool hasTimerStarted = false;

    private void OnBecameVisible()
    {
        if (!hasTimerStarted)
        {
            // 开始计时器，等待15秒后显示 FireElement
            StartCoroutine(ShowFire2AfterDelay(10));
            hasTimerStarted = true;
        }
    }

    private IEnumerator ShowFire2AfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // 15秒后执行的逻辑
        if (fire2Element != null)
        {
            // 将 FireElement 设为可见
            fire2Element.SetActive(true);
        }
    }

    private void OnBecameInvisible()
    {
        // 当 AddOilElement 不可见时，停止计时器并将 FireElement 设为不可见
        StopAllCoroutines();
        if (fire2Element != null)
        {
            fire2Element.SetActive(false);
        }
    }
}
