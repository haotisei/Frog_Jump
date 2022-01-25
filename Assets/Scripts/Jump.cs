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
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("ButtonClick");
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetTrigger("Jump");
        }
    }
}
