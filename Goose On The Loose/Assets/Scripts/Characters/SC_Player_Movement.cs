using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Player_Movement: MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D characterRigidBody;

    private Vector2 inputData;

    void Update()
    {
        inputData.x = Input.GetAxisRaw("Horizontal");
        inputData.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        characterRigidBody.MovePosition(characterRigidBody.position + inputData * moveSpeed * Time.fixedDeltaTime);
    }

}
