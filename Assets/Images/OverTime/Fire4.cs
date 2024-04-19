using System.Collections;
using UnityEngine;

public class StriFryElement : MonoBehaviour
{
    public GameObject fire4Element; // 引用 Fire3Element 元素
    private bool hasTimerStarted = false;

    private void OnEnable()
    {
        StartCoroutine(ActivateFireAfterDelay(61f));
    }

    private IEnumerator ActivateFireAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (fire4Element != null)
        {
            fire4Element.SetActive(true); // 将 Fire3Element 设为可见
        }
    }

    private void OnDisable()
    {
        if (fire4Element != null)
        {
            fire4Element.SetActive(false); // 将 Fire3Element 设为不可见
        }
    }
}
