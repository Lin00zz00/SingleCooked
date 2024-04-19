using UnityEngine;

namespace YourNamespace
{
    public class SwitchToChopTomatoesOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject prepareElement; // prepare元件
        public GameObject chopTomatoesElement; // chopTomatoes元件

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
                SwitchToChopTomatoes(); // 在识别到 "Pinched" 手势时切换到ChopTomatoes元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToChopTomatoes()
        {
            // 确保prepare元件和chopTomatoes元件不为空
            if (prepareElement != null && chopTomatoesElement != null)
            {
                // 禁用prepare元件
                prepareElement.SetActive(false);
                
                // 启用chopTomatoes元件
                chopTomatoesElement.SetActive(true);
            }
        }
    }
}
