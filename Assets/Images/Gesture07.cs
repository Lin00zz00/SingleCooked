using UnityEngine;

namespace YourNamespace
{
    public class SwitchToScallionOilOnPinch : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject fryEggsElement; // 当前元件（FryEggs元件）
        public GameObject scallionOilElement; // ScallionOil元件

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
                SwitchToScallionOil(); // 在识别到 "Pinched" 手势时切换到ScallionOil元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToScallionOil()
        {
            // 确保ScallionOil元件不为空
            if (scallionOilElement != null)
            {
                // 禁用当前元件（FryEggs元件）
                fryEggsElement.SetActive(false);
                
                // 启用ScallionOil元件
                scallionOilElement.SetActive(true);
            }
        }
    }
}
