using UnityEngine;

public class HopeManagers : MonoBehaviour
{
    public float currentTime = 0;
    private float dayTime = 24;

    public static HopeManagers Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); 
    }

    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
        if (currentTime > dayTime)
        {
            currentTime = 0;
        }
    }
}
