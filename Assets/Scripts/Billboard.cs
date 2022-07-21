using UnityEngine;

public class Billboard : MonoBehaviour
{
    SpriteRenderer sr;
    [SerializeField] Vector3 vector;
    [SerializeField] bool flipX = true;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.flipX = flipX;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(PlayerController.instance.transform.position, vector);
    }
}
