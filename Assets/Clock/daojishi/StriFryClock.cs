using UnityEngine;

namespace YourNamespace
{
    public class SwitchToTimerUIV4OnPinchedGesture : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public GameObject AddSaltElement; // AddSalt元件
        public GameObject TimerUIV4; // Timer UI V4元件

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
                SwitchToTimerUIV4(); // 在识别到 "Pinched" 手势时切换到Timer UI V4元件
                hasSwitched = true; // 将标志设置为已经切换过元件
            }
        }

        private void SwitchToTimerUIV4()
        {
            // 确保AddSalt元件和Timer UI V4元件不为空
            if (AddSaltElement != null && TimerUIV4 != null)
            {
                // 检查AddSalt元件是否可见
                if (!AddSaltElement.activeSelf)
                {
                    // AddSalt元件不可见，将Timer UI V4元件设为不可见
                    TimerUIV4.SetActive(false);
                }
                else
                {
                    // AddSalt元件可见，将Timer UI V4元件设为可见
                    TimerUIV4.SetActive(true);
                }

                // 禁用AddSalt元件
                AddSaltElement.SetActive(false);
            }
        }

        // 添加一个方法来切换到其他元素（例如AddSalt）
        private void SwitchToAddSalt()
        {
            // 确保AddSalt元件和Timer UI V4元件不为空
            if (AddSaltElement != null && TimerUIV4 != null)
            {
                // 确保Timer UI V4元件不可见
                TimerUIV4.SetActive(false);
                
                // 启用AddSalt元件
                AddSaltElement.SetActive(true);
            }
        }
    }
}