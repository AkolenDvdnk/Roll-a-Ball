using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (ScoreCounter.Collected)
        {
            animator.SetTrigger("Collected");
        }
    }
}
