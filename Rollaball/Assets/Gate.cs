using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (MissionManager.rubyCollected)
        {
            animator.SetBool("Collected", MissionManager.rubyCollected);
        }
    }
}
