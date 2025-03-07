using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CapsuleMovementWithJoystick : MonoBehaviour
{
    public float moveSpeed = 5f;  // �ƶ��ٶ�
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // ��ȡ�ֱ���ˮƽ�ʹ�ֱ������ֵ����ͬ�ֱ�����������ƻ��в��죬�����ǳ��������ƣ�
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ������������ƶ���������
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection = transform.TransformDirection(moveDirection);

        // ʹ��CharacterController��Move�����ƶ�������
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}