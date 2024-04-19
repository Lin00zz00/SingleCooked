using UnityEngine;

public class Demo02 : MonoBehaviour
{
    [SerializeField] Timer timer1;
    [SerializeField] Timer timer2;
    [SerializeField] Timer timer3;
    [SerializeField] Timer timer4;
    public GameObject timerUIV2; // 引用 Timer UI V1 元件

    private void Start()
    {
        if (timerUIV2 != null && timerUIV2.activeSelf) // 检查 Timer UI V1 是否可见
        {
            timer1
                .SetDuration(15)
                .OnEnd(() => Debug.Log("Timer 1 ended"))
                .Begin();
        }
        else
        {
            Debug.LogWarning("Timer UI V1 is not visible. Timer not started.");
        }
    }
}
