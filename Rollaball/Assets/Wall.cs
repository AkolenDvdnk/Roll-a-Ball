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
        if (MissionManager.goldCollected)
        {
            animator.SetBool("Collected", MissionManager.goldCollected);
        }
    }
}
