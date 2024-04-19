using UnityEngine;

namespace YourNamespace
{
    public class SwitchToStriFryOnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject addSaltElement; // AddSalt元件
        public GameObject striFryElement; // Stri-fry元件

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
                SwitchToStriFry(); // 在识别到 "Pinched" 手势时切换到Stri-fry元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToStriFry()
        {
            // 确保AddSalt元件和Stri-fry元件不为空
            if (addSaltElement != null && striFryElement != null)
            {
                // 禁用AddSalt元件
                addSaltElement.SetActive(false);
                
                // 启用Stri-fry元件
                striFryElement.SetActive(true);
            }
        }
    }
}
