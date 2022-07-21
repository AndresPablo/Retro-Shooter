using UnityEngine;

public class Pickup_Health : PickupObject
{
    public int cant = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            AudioManager.instance.PlayOneShot(sfx);
            other.GetComponent<PlayerHealth>().ChangeHealth(cant);
            Destroy(this.gameObject);
        }
    }
}
