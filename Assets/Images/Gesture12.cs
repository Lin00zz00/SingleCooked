using UnityEngine;

namespace YourNamespace
{
    public class SwitchToSucceedOnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject striFryElement; // Stri-fry元件
        public GameObject succeedElement; // Succeed元件

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
                SwitchToSucceed(); // 在识别到 "Pinched" 手势时切换到Succeed元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToSucceed()
        {
            // 确保Stri-fry元件和Succeed元件不为空
            if (striFryElement != null && succeedElement != null)
            {
                // 禁用Stri-fry元件
                striFryElement.SetActive(false);
                
                // 启用Succeed元件
                succeedElement.SetActive(true);
            }
        }
    }
}
