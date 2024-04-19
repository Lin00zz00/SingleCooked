using UnityEngine;

namespace YourNamespace
{
    public class SwitchToMenu01OnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject handPoseElement; // HandPose元件
        public GameObject menu01Element; // menu01元件

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
                SwitchToMenu01(); // 在识别到 "Pinched" 手势时切换到menu01元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToMenu01()
        {
            // 确保HandPose元件和menu01元件不为空
            if (handPoseElement != null && menu01Element != null)
            {
                // 禁用HandPose元件
                handPoseElement.SetActive(false);
                
                // 启用menu01元件
                menu01Element.SetActive(true);
            }
        }
    }
}
