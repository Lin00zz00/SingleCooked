using UnityEngine;

public class FollowModelLocalPosition : MonoBehaviour
{
    public Transform modelTransform; // 模型的Transform组件
    public Transform expressionTransform; // 表情贴图的Transform组件

    void Update()
    {
        // 获取模型的局部位置
        Vector3 modelLocalPosition = modelTransform.localPosition;

        // 获取表情贴图相对于模型原点的位置偏移量
        Vector3 expressionOffsetFromPivot = expressionTransform.position - modelTransform.position;

        // 计算表情贴图应该移动到的位置
        Vector3 expressionPosition = modelLocalPosition + expressionOffsetFromPivot;

        // 将表情贴图的位置设置为计算得到的位置
        expressionTransform.localPosition = expressionPosition;
    }
}