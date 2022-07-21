using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHP = 3;
    int HP;
    [Space]
    public bool isAwake = true;
    public Rigidbody rb;
    public float moveSpeed = 2f;
    public float searchRange = 10f;
    [Space]
    public AudioClip dieSFX;
    public AudioClip damageSFX;
    public AudioClip shootSFX;


    void Start()
    {
        HP = maxHP;    
    }

    public void TakeDamage(int amount)
    {
        HP -= amount;
        if (damageSFX) AudioManager.instance.PlayOneShot(damageSFX);

        if (HP <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(this.gameObject);
        if(dieSFX) AudioManager.instance.PlayOneShot(dieSFX);
    }

    void SearchPlayer()
    {
        float dist = Vector3.Distance(transform.position, PlayerController.instance.transform.position);
        if (dist < searchRange && dist > 1)
        {
            Vector3 playerDirection = PlayerController.instance.transform.position - transform.position;
            rb.velocity = playerDirection.normalized * moveSpeed;
        }
    }

    void AttackPlayer()
    {

    }


    void Update()
    {
        if(isAwake) SearchPlayer();
    }
}
