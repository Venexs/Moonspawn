using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPreloader : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();

    void Awake()
    {
        GameObject instantiated;
        foreach (GameObject prefab in prefabs)
        {
            instantiated = Instantiate(prefab) as GameObject;
            instantiated.SetActive(true);
            instantiated.SetActive(false);
            Destroy(instantiated);
        }

    }   
}
