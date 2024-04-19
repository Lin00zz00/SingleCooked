using UnityEngine;

namespace YourNamespace
{
    public class SwitchToSimmerOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject fryTomatoesElement; // 当前元件（FryTomatoes元件）
        public GameObject simmerElement; // Simmer元件

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
                SwitchToSimmer(); // 在识别到 "Pinched" 手势时切换到Simmer元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToSimmer()
        {
            // 确保Simmer元件不为空
            if (simmerElement != null)
            {
                // 禁用当前元件（FryTomatoes元件）
                fryTomatoesElement.SetActive(false);
                
                // 启用Simmer元件
                simmerElement.SetActive(true);
            }
        }
    }
}
