using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    [SerializeField] float tiempoDestruir = 2f;


    void Start()
    {
        Destroy(this.gameObject, tiempoDestruir);
    }

}
