using UnityEngine;

namespace YourNamespace
{
    public class SwitchToAddSaltOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject simmerElement; // 当前元件（Simmer元件）
        public GameObject addSaltElement; // AddSalt元件

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
                SwitchToAddSalt(); // 在识别到 "Pinched" 手势时切换到AddSalt元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToAddSalt()
        {
            // 确保AddSalt元件不为空
            if (addSaltElement != null)
            {
                // 禁用当前元件（Simmer元件）
                simmerElement.SetActive(false);
                
                // 启用AddSalt元件
                addSaltElement.SetActive(true);
            }
        }
    }
}
