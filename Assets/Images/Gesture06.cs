using UnityEngine;

namespace YourNamespace
{
    public class SwitchToFryEggsOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject addOilElement; // 当前元件（AddOil元件）
        public GameObject fryEggsElement; // FryEggs元件

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
                SwitchToFryEggs(); // 在识别到 "Pinched" 手势时切换到FryEggs元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToFryEggs()
        {
            // 确保FryEggs元件不为空
            if (fryEggsElement != null)
            {
                // 禁用当前元件（AddOil元件）
                addOilElement.SetActive(false);
                
                // 启用FryEggs元件
                fryEggsElement.SetActive(true);
            }
        }
    }
}
