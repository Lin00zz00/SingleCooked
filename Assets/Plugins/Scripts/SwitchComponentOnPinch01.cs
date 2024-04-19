using System;
using UnityEngine;

public class GestureManager : MonoBehaviour
{
    public static GestureManager Instance; // 创建一个单例实例

    public event Action<string, string> OnComponentSwitched; // 定义元件切换事件

    private void Awake()
    {
        // 确保只存在一个实例
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 在此方法中处理手势识别逻辑
    public void RecognizeGesture(string gesture)
    {
        // 如果识别到了 Prepare 切换到 ChopTomatoes 的手势
        if (gesture == "ChopTomatoes")
        {
            // 触发元件切换事件，并传递相应的元件名称
            OnComponentSwitched?.Invoke("Prepare", "ChopTomatoes");
        }
        // 如果识别到了 ChopTomatoes 切换到 BreakEggs 的手势
        else if (gesture == "BreakEggs")
        {
            // 触发元件切换事件，并传递相应的元件名称
            OnComponentSwitched?.Invoke("ChopTomatoes", "BreakEggs");
        }
        // 其他手势识别逻辑...
    }

    // 在销毁时取消事件监听
    private void OnDestroy()
    {
        OnComponentSwitched = null;
    }
}
