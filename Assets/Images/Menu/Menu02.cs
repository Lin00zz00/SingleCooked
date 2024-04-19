using UnityEngine;

namespace YourNamespace
{
    public class SwitchToMenu03OnFiveGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject menu02Element; // menu02元件
        public GameObject menu03Element; // menu03元件

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
            if (gesture == HoloKit.iOS.HandGesture.Five && !hasSwitched)
            {
                SwitchToMenu03(); // 在识别到 "Five" 手势时切换到menu03元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToMenu03()
        {
            // 确保menu02元件和menu03元件不为空
            if (menu02Element != null && menu03Element != null)
            {
                // 禁用menu02元件
                menu02Element.SetActive(false);
                
                // 启用menu03元件
                menu03Element.SetActive(true);
            }
        }
    }
}
