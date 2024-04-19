using UnityEngine;

public class Demo1 : MonoBehaviour
{
    [SerializeField] Timer timer1;
    [SerializeField] Timer timer2;
    [SerializeField] Timer timer3;
    [SerializeField] Timer timer4;
    public GameObject TimerUIV01; // 引用 Timer UI V1 元件

    private void Start()
    {
        if (TimerUIV01 != null && TimerUIV01.activeSelf) // 检查 Timer UI V1 是否可见
        {
            timer1
                .SetDuration(15)
                .OnEnd(() => Debug.Log("Timer 1 ended"))
                .Begin();
        }
        else
        {
            Debug.LogWarning("Timer UI V01 is not visible. Timer not started.");
        }
    }
}
