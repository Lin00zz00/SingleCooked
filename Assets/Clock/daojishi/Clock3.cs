using UnityEngine;

namespace YourNamespace
{
    public class SwitchToTimerUIV3OnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject FryTomatoesElement; // FryTomatoes元件
        public GameObject TimerUIV3; // Timer UI V3元件

        private bool hasSwitched = false; // 标志是否已经切换过元件

        private void OnEnable()
        {
            if (gestureManager != null)
                gestureManager.OnHandGestureChanged += OnHandGestureChanged; // 注册手势变化事件
        }

        private void OnDisable()
        {
            if (gestureManager != null)
                gestureManager.OnHandGestureChanged -= OnHandGestureChanged; // 取消注册手势变化事件
        }

        private void OnHandGestureChanged(HoloKit.iOS.HandGesture gesture)
        {
            if (gesture == HoloKit.iOS.HandGesture.Pinched && !hasSwitched)
            {
                SwitchToTimerUIV3(); // 在识别到 "Pinched" 手势时切换到Timer UI V3元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToTimerUIV3()
        {
            // 确保FryTomatoes元件和Timer UI V3元件不为空
            if (FryTomatoesElement != null && TimerUIV3 != null)
            {
                // 检查FryTomatoes元件是否可见
                if (!FryTomatoesElement.activeSelf)
                {
                    // FryTomatoes元件不可见，将Timer UI V3元件设为不可见
                    TimerUIV3.SetActive(false);
                }
                else
                {
                    // FryTomatoes元件可见，将Timer UI V3元件设为可见
                    TimerUIV3.SetActive(true);
                }

                // 禁用FryTomatoes元件
                FryTomatoesElement.SetActive(false);
            }
        }

        // 添加一个方法来切换到其他元素（例如FryTomatoes）
        private void SwitchToFryTomatoes()
        {
            // 确保FryTomatoes元件和Timer UI V3元件不为空
            if (FryTomatoesElement != null && TimerUIV3 != null)
            {
                // 确保Timer UI V3元件不可见
                TimerUIV3.SetActive(false);
                
                // 启用FryTomatoes元件
                FryTomatoesElement.SetActive(true);
            }
        }
    }
}
