using UnityEngine;

namespace YourNamespace
{
    public class SwitchToPrepareOnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject menu03Element; // menu03元件
        public GameObject prepareElement; // Prepare元件

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
                SwitchToPrepare(); // 在识别到 "Pinched" 手势时切换到Prepare元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToPrepare()
        {
            // 确保menu03元件和Prepare元件不为空
            if (menu03Element != null && prepareElement != null)
            {
                // 禁用menu03元件
                menu03Element.SetActive(false);
                
                // 启用Prepare元件
                prepareElement.SetActive(true);
            }
        }
    }
}
