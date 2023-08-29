using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Player_Honk : MonoBehaviour
{


    public Camera playerCam;
    private SC_Audio_Manager audioManager;
    public GameObject honkPrefab;
    public Rigidbody2D playerRigidbody;
    public GameObject gooseHead;
    private Rigidbody2D gooseHeadRigidBody;
    private Transform gooseHeadTransform;
    public float honkForce = 20f;


    private string Honk;
    private Vector2 mousePosition;
    private Vector2 lookDirection;


    private void Awake()
    {
        audioManager = GetComponent<SC_Audio_Manager>();
        Honk = "Honk";
        gooseHeadRigidBody = gooseHead.GetComponent<Rigidbody2D>();
        gooseHeadTransform = gooseHead.GetComponent<Transform>();
    }

    private void Update()
    {

        mousePosition = playerCam.ScreenToWorldPoint(Input.mousePosition);
        lookDirection = mousePosition - playerRigidbody.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        gooseHeadRigidBody.rotation = lookAngle;


        if (Input.GetMouseButtonDown(0))
        {
            audioManager.PlayRandomSound(Honk);
            FireHonk();
        }

    }

    public void FireHonk()
    {
        GameObject honk = Instantiate(honkPrefab, playerRigidbody.position, gooseHeadTransform.rotation);
        honk.GetComponent<Rigidbody2D>().AddForce(gooseHeadTransform.up * honkForce, ForceMode2D.Impulse);
    }
    

}
