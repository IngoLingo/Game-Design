using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMoverScript : MonoBehaviour
{
    //public float moveSpeed = 5f, gravity = 3f;
    public bool ResetStats;
    public Create_FloatVariable moveSpeed;
    private CharacterController controller;
    private Vector3 position;
    //public IntData jumpData;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (ResetStats)
        {
            moveSpeed.ChangeValue(moveSpeed.minValue);
        }
    }
    
    void Update()
    {
        position.x = moveSpeed.value * Input.GetAxis("Horizontal");
        position.z = moveSpeed.value * Input.GetAxis("Vertical");
        /*position.y -= gravity;

        if (Input.GetButton("Jump") && jumpData.value < jumpData.maxValue)
        {
            position.y = jumpSpeed;
            jumpData.value++;
        } else if (controller.isGrounded)
        {
            position.y = 0;
        }*/
        controller.Move(position * Time.deltaTime);
    }
}
