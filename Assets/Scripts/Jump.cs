using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("JumpSet");
        }
        if (Input.GetButtonUp("Jump"))
        {
            animator.SetTrigger("JumpRelease");
        }
    }
}
