using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject deathEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            
            GameObject effect = (GameObject)Instantiate(deathEffect, other.transform.position, other.transform.rotation);
            Destroy(effect, 3f);
        }
    }
}
