using UnityEngine;

namespace YourNamespace
{
    public class SwitchToMenu02OnFiveGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject menu01Element; // menu01元件
        public GameObject menu02Element; // menu02元件

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
                SwitchToMenu02(); // 在识别到 "Five" 手势时切换到menu02元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToMenu02()
        {
            // 确保menu01元件和menu02元件不为空
            if (menu01Element != null && menu02Element != null)
            {
                // 禁用menu01元件
                menu01Element.SetActive(false);
                
                // 启用menu02元件
                menu02Element.SetActive(true);
            }
        }
    }
}
