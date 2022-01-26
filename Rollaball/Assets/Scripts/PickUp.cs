using UnityEngine;

public enum PickUpType
{
    gold,
    ruby
}
public class PickUp : MonoBehaviour
{
    public PickUpType pickUpType;

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
        if (other.CompareTag("Player") && pickUpType.ToString() == "gold")
        {
            MissionManager.GoldScore++;
            Destroy(gameObject);
        }
        if (other.CompareTag("Player") && pickUpType.ToString() == "ruby")
        {
            MissionManager.RubyScore++;
            Destroy(gameObject);
        }
    }
}
