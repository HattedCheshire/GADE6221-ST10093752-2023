using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contoller : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            if (Input.GetKeyDown(KeyCode.i) || Input.GetKeyDown(KeyCode.1))
            {
                animator.SetTrigger("Idle");
            }
            if (Input.GetKeyDown(KeyCode.w) || Input.GetKeyDown(KeyCode.2))
            {
                animator.SetTrigger("Walk");
            }
            if (Input.GetKeyDown(KeyCode.r) || Input.GetKeyDown(KeyCode.3))
            {
                animator.SetTrigger("Run");
            }
            if (Input.GetKeyDown(KeyCode.f) || Input.GetKeyDown(KeyCode.4))
            {
                animator.SetTrigger("Fight");
            }
            if (Input.GetKeyDown(KeyCode.d) || Input.GetKeyDown(KeyCode.5))
            {
                animator.SetTrigger("Die");
            }
        }
    }
}
