using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void Update()
    {
        Rotate();
    }   
    private void Rotate()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreCounter.Score++;
            Destroy(gameObject);
        }
    }
}
