using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSubstance : MonoBehaviour
{
    public GameObject fence;
    public GameObject newTeleportPos;

    private Animator fenceAnimator;

    private void Awake()
    {
        fenceAnimator = fence.GetComponent<Animator>();
    }
    private void Update()
    {
        RemoveTheFence();
    }
    private void RemoveTheFence()
    {
        if (ButtonBox.buttonPressed)
        {
            fenceAnimator.SetTrigger("Triggered");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = newTeleportPos.transform.position;
        }
    }
}
