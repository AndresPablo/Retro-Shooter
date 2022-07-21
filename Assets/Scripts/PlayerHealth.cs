using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    bool hasDied;


    void Start()
    {
        currentHP = maxHP;
    }

    public void ChangeHealth(int amount)
    {
        currentHP += amount;
        if(currentHP <= 0)
        {
            Kill();
        }
    }

    void Respawn()
    {
        hasDied = false;
    }

    void Kill()
    {
        hasDied = true;
        Debug.Log("muerto");
    }
}
