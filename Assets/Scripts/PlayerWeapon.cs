using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] Animator gunAnim;
    [Space]
    public GameObject bulletImpact_prefab;
    public AudioClip shoot_sfx;
    public float distancia = 20f;
    public int damage = 1;
    public int maxAmmo;
    public int ammo;


    void Start()
    {
        
    }

    void Update()
    {
        Vector3 dir = new Vector3(.5f, .0f, .5f);
        Debug.DrawRay(Camera.main.transform.position, dir);
        // Shooting
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo <= 0)
            {
                Recarga();
                return;
            }

            Camera cam = Camera.main;
            RaycastHit hit;
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distancia))
            {
                Instantiate(bulletImpact_prefab, hit.point, transform.rotation);
                hit.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
                //Debug.Log("le dispare a " + hit.transform.name);
                AudioManager.instance.PlayOneShot(shoot_sfx);
                ammo--;
                gunAnim.SetTrigger("Shoot");
            }

        }
    }

    public void Recarga(int amount)
    {
        ammo += amount;
    }

    public void Recarga()
    {
        ammo = maxAmmo;
    }
}
