using UnityEngine;

public class door : MonoBehaviour
{
    public bool open;

    public void openDoor()
    {
        open = true;
        gameObject.transform.position = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
    }
}
