using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // 要跟随的目标（角色）
    public Vector3 initialOffset;  // 摄像机一开始相对于目标的偏移量，用于使摄像机远离物体
    public Vector3 followOffset;  // 后续跟随过程中摄像机相对于目标的偏移量

    private bool isInitialOffsetSet = false;  // 标记是否已经设置过初始偏移量

    void LateUpdate()
    {
        if (target != null)
        {
            if (!isInitialOffsetSet)
            {
                // 在首次更新时，设置初始偏移量
                transform.position = target.position + initialOffset;
                isInitialOffsetSet = true;
            }
            else
            {
                // 后续更新时，使用跟随偏移量
                Vector3 targetPosition = target.position + followOffset;
                transform.position = targetPosition;
            }
        }
    }
}