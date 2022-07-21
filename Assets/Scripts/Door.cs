using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform doorModel;
    public Collider fisCol;
    public float openSpeed;
    public bool opening;
    public Vector3 openDir;
    Vector3 originalPos;


    void Start()
    {
        originalPos = doorModel.position;
    }

    private void Update()
    {
        if(opening )
        {
            doorModel.position = Vector3.MoveTowards(doorModel.position, originalPos + openDir, openSpeed * Time.deltaTime);
        }
        else
        if (!opening)
        {
            doorModel.position = Vector3.MoveTowards(doorModel.position, originalPos, openSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            opening = true;
            //fisCol.enabled = false;
        }
        else
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            opening = false;
            //fisCol.enabled = true;
        }
        else
        {

        }
    }
}
