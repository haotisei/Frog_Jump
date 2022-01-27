using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMotion : MonoBehaviour
{
    private bool onGround;
    private float jumpPressure;
    private float minJump;
    private float maxJumpPressure;

    public Rigidbody rbody;

    void Start()
    {
        
        onGround = true;
        jumpPressure = 0f;
        minJump = 2f;
        maxJumpPressure = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(onGround)
        {
            if(Input.GetButton("Jump"))
            {
                if(jumpPressure < maxJumpPressure)
                {
                    jumpPressure += Time.deltaTime * 10f;
                }
            else
                {
                    jumpPressure = maxJumpPressure;
                }
                print(jumpPressure);
            }

            else
            {
                if(jumpPressure >0f)
                {
                    jumpPressure = jumpPressure + minJump;
                    rbody.velocity = new Vector3(jumpPressure, jumpPressure, 0f);
                    jumpPressure = 0f;
                    onGround = false;
                }
            }
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
    }
}
