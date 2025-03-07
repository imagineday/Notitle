using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CapsuleMovementWithJoystick : MonoBehaviour
{
    public float moveSpeed = 5f;  // 移动速度
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 获取手柄的水平和垂直输入轴值（不同手柄可能轴的名称会有差异，这里是常见的名称）
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 根据输入计算移动方向向量
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection = transform.TransformDirection(moveDirection);

        // 使用CharacterController的Move方法移动胶囊体
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}