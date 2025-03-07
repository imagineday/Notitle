using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Ҫ�����Ŀ�꣨��ɫ��
    public Vector3 initialOffset;  // �����һ��ʼ�����Ŀ���ƫ����������ʹ�����Զ������
    public Vector3 followOffset;  // �����������������������Ŀ���ƫ����

    private bool isInitialOffsetSet = false;  // ����Ƿ��Ѿ����ù���ʼƫ����

    void LateUpdate()
    {
        if (target != null)
        {
            if (!isInitialOffsetSet)
            {
                // ���״θ���ʱ�����ó�ʼƫ����
                transform.position = target.position + initialOffset;
                isInitialOffsetSet = true;
            }
            else
            {
                // ��������ʱ��ʹ�ø���ƫ����
                Vector3 targetPosition = target.position + followOffset;
                transform.position = targetPosition;
            }
        }
    }
}