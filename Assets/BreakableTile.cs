using UnityEngine;

public class BreakableTile : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Material AltMaterial;
    public int maxHP;
    [Space]
    public GameObject vfx;
    public AudioClip sfx;
    int hp;

    private void Start()
    {
        hp = maxHP;
    }

    public void TakeDamage(int amount)
    {
        if(hp == maxHP)
        {
            if (sfx) AudioManager.instance.PlayOneShot(sfx);
            meshRenderer.material = AltMaterial;
        }else
        if(hp <= 0)
        {
            if (vfx) Instantiate(vfx, transform.position, transform.rotation);
            if (sfx) AudioManager.instance.PlayOneShot(sfx);
            Destroy(this.gameObject);
        }
        hp--;

    }

}
