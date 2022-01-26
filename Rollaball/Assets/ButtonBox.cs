using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBox : MonoBehaviour
{
    public static bool buttonPressed = false;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            buttonPressed = true;
            animator.SetTrigger("Triggered");
        }
    }
}
