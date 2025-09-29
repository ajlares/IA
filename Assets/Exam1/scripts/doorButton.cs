using System;
using UnityEngine;

public class doorButton : MonoBehaviour
{
    public bool waPresssed;
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bob"))
        {
            waPresssed = true;
            door.GetComponent<door>().openDoor();
        }
    }
}
