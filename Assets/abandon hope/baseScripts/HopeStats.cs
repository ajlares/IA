using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HopeStats : MonoBehaviour
{
    public float speed;
    public NavMeshAgent agent;
    public GameObject ShopGameObject;
    public GameObject HaouseGameObject;
    public List<GameObject> workWaipoint;

    [Header("garbage")]
    private float garbageIndexTime;

    private void Update()
    {
        if (garbageIndexTime >= HopeManagers.Instance.garbageTime)
        {
            garbageIndexTime = 0;
            HopeManagers.Instance.AddGarbage(transform.position);
        }
        garbageIndexTime += Time.deltaTime;
    }
}