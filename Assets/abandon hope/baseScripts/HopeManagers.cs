using UnityEngine;
public class HopeManagers : MonoBehaviour
{
    public float hourDuration = 60;
    public float currentTime = 0;
    private float dayTime = 24;
    public float indexTime = 0;
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
        indexTime += Time.fixedDeltaTime;
        if (indexTime > hourDuration)
        {
            currentTime++;
            indexTime = 0;
            if (currentTime > dayTime)
            {
             currentTime = 1;   
            }
        }
    }
}
