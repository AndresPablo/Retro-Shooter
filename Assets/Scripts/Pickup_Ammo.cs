using UnityEngine;

public class Pickup_Ammo : PickupObject
{
    public int cant = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerWeapon>().Recarga(cant) ;
            AudioManager.instance.PlayOneShot(sfx);
            Destroy(this.gameObject);

        }
    }
}
