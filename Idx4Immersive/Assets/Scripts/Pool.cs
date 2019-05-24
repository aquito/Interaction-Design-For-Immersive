﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolItem{
    public GameObject prefab;
    public int maxAmount;
}

public class Pool : MonoBehaviour
{
    public static Pool singleton;
    public List<PoolItem> items;
    public List<GameObject> pooledItems;
    
   /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        singleton = this;

    }

    public GameObject Get(string tag)
    {
        for(int i = 0; i < pooledItems.Count; i++)
        {
            if(!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[i];
            }
        }
        return null;
    }
    // Start is called before the first frame update
    void Start()
    {
        pooledItems = new List<GameObject>();
        foreach(PoolItem item in items)
        {
            for(int i = 0; i < item.maxAmount; i++)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }
    }

   
}
