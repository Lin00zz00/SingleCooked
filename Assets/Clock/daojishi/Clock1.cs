using UnityEngine;

namespace YourNamespace
{
    public class SwitchToTimerUIV1OnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject ChopOnionElement; // ChopOnions元件
        public GameObject TimerUIV1; // Timer UI V1元件

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
                SwitchToTimerUIV1(); // 在识别到 "Pinched" 手势时切换到Timer UI V1元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToTimerUIV1()
        {
            // 确保ChopOnions元件和Timer UI V1元件不为空
            if (ChopOnionElement != null && TimerUIV1 != null)
            {
                // 检查ChopOnions元件是否可见
                if (!ChopOnionElement.activeSelf)
                {
                    // ChopOnions元件不可见，将Timer UI V1元件设为不可见
                    TimerUIV1.SetActive(false);
                }
                else
                {
                    // ChopOnions元件可见，将Timer UI V1元件设为可见
                    TimerUIV1.SetActive(true);
                }

                // 禁用ChopOnions元件
                ChopOnionElement.SetActive(false);
            }
        }

        // 添加一个方法来切换到其他元素（例如ChopOnions）
        private void SwitchToChopOnions()
        {
            // 确保ChopOnions元件和Timer UI V1元件不为空
            if (ChopOnionElement != null && TimerUIV1 != null)
            {
                // 确保Timer UI V1元件不可见
                TimerUIV1.SetActive(false);
                
                // 启用ChopOnions元件
                ChopOnionElement.SetActive(true);
            }
        }
    }
}
