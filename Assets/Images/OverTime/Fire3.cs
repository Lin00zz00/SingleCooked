using System.Collections;
using UnityEngine;

public class SimmerElement : MonoBehaviour
{
    public GameObject fire3Element; // 引用 Fire3Element 元素
    private bool hasTimerStarted = false;

    private void OnEnable()
    {
        StartCoroutine(ActivateFireAfterDelay(91f));
    }

    private IEnumerator ActivateFireAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (fire3Element != null)
        {
            fire3Element.SetActive(true); // 将 Fire3Element 设为可见
        }
    }

    private void OnDisable()
    {
        if (fire3Element != null)
        {
            fire3Element.SetActive(false); // 将 Fire3Element 设为不可见
        }
    }
}
