using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Player_Movement: MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D characterRigidBody;
    public Animator characterAnimationController;
    private Vector2 inputData;

    void Update()
    {
        GetPlayerInput();
        UpdatePlayerAnimator();
   
    }

    void FixedUpdate()
    {
        MovePlayer();
    }



    public void GetPlayerInput()
    {
        inputData.x = Input.GetAxisRaw("Horizontal");
        inputData.y = Input.GetAxisRaw("Vertical");
    }

    public void UpdatePlayerAnimator()  // Updates variables in player animator
    {
        characterAnimationController.SetFloat("Horizontal_Input", inputData.x);
        characterAnimationController.SetFloat("Vertical_Input", inputData.y);
        characterAnimationController.SetFloat("Speed", inputData.sqrMagnitude);

        if (inputData.sqrMagnitude != 0)
        {
            characterAnimationController.SetFloat("Idle_Direction_Horizontal", inputData.x);
            characterAnimationController.SetFloat("Idle_Direction_Vertical", inputData.y);
        }
    }

    public void MovePlayer()
    {
        characterRigidBody.MovePosition(characterRigidBody.position + inputData.normalized * moveSpeed * Time.fixedDeltaTime);
    }

}
