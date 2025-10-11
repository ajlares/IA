using System;
using UnityEngine;

public class HopeManagers : MonoBehaviour
{
    public float currentTIme = 0;
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
        currentTIme += Time.fixedDeltaTime;
        if (currentTIme > dayTime)
        {
            currentTIme = 0;
        }
    }
}
