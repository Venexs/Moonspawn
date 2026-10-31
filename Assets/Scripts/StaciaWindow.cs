using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaciaWindow : MonoBehaviour
{
    public GameObject Stacia;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Stacia.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Stacia.SetActive(false);
        }
    }
}
