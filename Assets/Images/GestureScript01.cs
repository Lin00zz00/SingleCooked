using UnityEngine;

namespace YourNamespace
{
    public class PinchGestureAnimatorTrigger : MonoBehaviour
    {
        public HoloKit.iOS.HandGestureRecognitionManager gestureManager; // 引用手势识别管理器
        public Animator animator; // 引用 Animator 组件
        public string triggerName = "OpenSquare"; // 触发器名称

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
            if (gesture == HoloKit.iOS.HandGesture.Pinched)
            {
                ActivateAnimatorTrigger(); // 在识别到 "Pinched" 手势时触发 Animator 触发器
            }
        }

        private void ActivateAnimatorTrigger()
        {
            if (animator != null) // 确保 Animator 组件存在
            {
                animator.SetTrigger(triggerName); // 触发 Animator 中的 Trigger
            }
        }
    }
}
