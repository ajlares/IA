using System.Collections.Generic;
using UnityEngine;
public class HopeManagers : MonoBehaviour
{
    public float hourDuration = 60;
    public float currentTime = 0;
    private float dayTime = 24;
    public float indexTime = 0;
    
    [Header("garbage")]
    public int garbageAmount = 0;
    public List<GameObject> GarbagesList;
    public GameObject garbageprefab;
    public float garbageTime = 0;
    [Header("Instance")]
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
    public void AddGarbage(Vector3 position)
    {
        GameObject aux;
        aux = Instantiate(garbageprefab, position, Quaternion.identity);
        garbageAmount++;
        GarbagesList.Add(aux);
    }

    public void RemoveGarbage(GameObject garbageGameObject)
    {
        GarbagesList.Remove(garbageGameObject);
        garbageAmount--;
        Destroy(garbageGameObject);
    }
}
