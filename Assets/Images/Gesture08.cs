using UnityEngine;

namespace YourNamespace
{
    public class SwitchToFryTomatoesOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject scallionOilElement; // 当前元件（ScallionOil元件）
        public GameObject fryTomatoesElement; // FryTomatoes元件

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
                SwitchToFryTomatoes(); // 在识别到 "Pinched" 手势时切换到FryTomatoes元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToFryTomatoes()
        {
            // 确保FryTomatoes元件不为空
            if (fryTomatoesElement != null)
            {
                // 禁用当前元件（ScallionOil元件）
                scallionOilElement.SetActive(false);
                
                // 启用FryTomatoes元件
                fryTomatoesElement.SetActive(true);
            }
        }
    }
}
