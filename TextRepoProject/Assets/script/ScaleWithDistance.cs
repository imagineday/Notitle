using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ScaleWithDistance : MonoBehaviour
{
    public Camera targetCamera;  // Ŀ�������
    public float minScale = 0.5f;  // ��С����ֵ
    public float maxScale = 2f;  // �������ֵ
    public float minDistance = 5f;  // ������������ʱ�ľ���
    public float maxDistance = 20f;  // �����������Զʱ�ľ���

    void Update()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main;  // ���δָ������������Ի�ȡ�������
        }

        // �����ɫ�������֮��ľ���
        float distance = Vector3.Distance(transform.position, targetCamera.transform.position);

        // ���ݾ���������ű���
        float scaleFactor = Mathf.InverseLerp(maxDistance, minDistance, distance);

        // ȷ�����ű�������С���������ֵ֮��
        float scale = Mathf.Lerp(minScale, maxScale, scaleFactor);

        // ���ý�ɫ������
        transform.localScale = Vector3.one * scale;
    }
}