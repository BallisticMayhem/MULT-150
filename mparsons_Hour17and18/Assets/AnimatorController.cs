using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            animator.SetTrigger("PressW");

        if (Input.GetKeyDown(KeyCode.A))
            animator.SetTrigger("PressA");

        if (Input.GetKeyDown(KeyCode.S))
            animator.SetTrigger("PressS");

        if (Input.GetKeyDown(KeyCode.D))
            animator.SetTrigger("PressD");
    }
}
