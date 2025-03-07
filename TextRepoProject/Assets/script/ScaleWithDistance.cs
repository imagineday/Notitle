using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ScaleWithDistance : MonoBehaviour
{
    public Camera targetCamera;  // 目标摄像机
    public float minScale = 0.5f;  // 最小缩放值
    public float maxScale = 2f;  // 最大缩放值
    public float minDistance = 5f;  // 距离摄像机最近时的距离
    public float maxDistance = 20f;  // 距离摄像机最远时的距离

    void Update()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main;  // 如果未指定摄像机，尝试获取主摄像机
        }

        // 计算角色与摄像机之间的距离
        float distance = Vector3.Distance(transform.position, targetCamera.transform.position);

        // 根据距离计算缩放比例
        float scaleFactor = Mathf.InverseLerp(maxDistance, minDistance, distance);

        // 确保缩放比例在最小和最大缩放值之间
        float scale = Mathf.Lerp(minScale, maxScale, scaleFactor);

        // 设置角色的缩放
        transform.localScale = Vector3.one * scale;
    }
}