using System;
using System.Collections.Generic;
using UnityEngine;

public class mapManager : MonoBehaviour
{
    public List<GameObject> Trees;
    public int woodAcount = 0;
    public static mapManager Instance;

    private void Awake()
    {
        Instance = this;
    }
}
