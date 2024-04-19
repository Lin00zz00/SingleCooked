using UnityEngine;

namespace YourNamespace
{
    public class SwitchToTimerUIV2OnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject FryEggsElement; // FryEggs元件
        public GameObject TimerUIV2; // Timer UI V2元件

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
                SwitchToTimerUIV2(); // 在识别到 "Pinched" 手势时切换到Timer UI V2元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToTimerUIV2()
        {
            // 确保FryEggs元件和Timer UI V2元件不为空
            if (FryEggsElement != null && TimerUIV2 != null)
            {
                // 检查FryEggs元件是否可见
                if (!FryEggsElement.activeSelf)
                {
                    // FryEggs元件不可见，将Timer UI V2元件设为不可见
                    TimerUIV2.SetActive(false);
                }
                else
                {
                    // FryEggs元件可见，将Timer UI V2元件设为可见
                    TimerUIV2.SetActive(true);
                }

                // 禁用FryEggs元件
                FryEggsElement.SetActive(false);
            }
        }

        // 添加一个方法来切换到其他元素（例如FryEggs）
        private void SwitchToFryEggs()
        {
            // 确保FryEggs元件和Timer UI V2元件不为空
            if (FryEggsElement != null && TimerUIV2 != null)
            {
                // 确保Timer UI V2元件不可见
                TimerUIV2.SetActive(false);
                
                // 启用FryEggs元件
                FryEggsElement.SetActive(true);
            }
        }
    }
}

