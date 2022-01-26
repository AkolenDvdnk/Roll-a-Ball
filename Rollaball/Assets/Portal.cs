using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject fence;
    public GameObject newTeleportPos;
    public GameObject portalEffect;

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

            GameObject effect = (GameObject)Instantiate(portalEffect, other.transform.position, other.transform.rotation);
            Destroy(effect, 3f);
        }
    }
}
