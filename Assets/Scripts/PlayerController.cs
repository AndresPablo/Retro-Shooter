using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public Rigidbody rb;
    public float moveSpeed = 5f;
    Vector2 moveInput;
    Vector2 mouseInput;

    public float mouseSensitivity = 1f;

    public Transform camTrans;
    [Space]
    public PlayerWeapon Weapons;
    public PlayerHealth Health;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 moveHorizontal = transform.right * moveInput.x;
        Vector3 moveVertical= transform.forward * moveInput.y;
        rb.velocity = (moveHorizontal + moveVertical) * moveSpeed;

        // Player view control
        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y") * mouseSensitivity);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z );

        camTrans.localRotation = Quaternion.Euler(camTrans.localRotation.eulerAngles + new Vector3(-mouseInput.y, 0f  ,  0f) );
    }
}
