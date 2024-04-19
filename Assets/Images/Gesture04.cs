using UnityEngine;

namespace YourNamespace
{
    public class SwitchToChopOnionsOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject breakEggsElement; // 当前元件（BreakEggs元件）
        public GameObject chopOnionsElement; // ChopOnions元件

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
                SwitchToChopOnions(); // 在识别到 "Pinched" 手势时切换到ChopOnions元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToChopOnions()
        {
            // 确保ChopOnions元件不为空
            if (chopOnionsElement != null)
            {
                // 禁用当前元件（BreakEggs元件）
                breakEggsElement.SetActive(false);
                
                // 启用ChopOnions元件
                chopOnionsElement.SetActive(true);
            }
        }
    }
}
