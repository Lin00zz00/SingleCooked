using UnityEngine;

namespace YourNamespace
{
    public class SwitchToHandPoseOnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject titleElement; // Title元件
        public GameObject handPoseElement; // HandPose元件

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
                SwitchToHandPose(); // 在识别到 "Pinched" 手势时切换到HandPose元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToHandPose()
        {
            // 确保Title元件和HandPose元件不为空
            if (titleElement != null && handPoseElement != null)
            {
                // 禁用Title元件
                titleElement.SetActive(false);
                
                // 启用HandPose元件
                handPoseElement.SetActive(true);
            }
        }
    }
}
