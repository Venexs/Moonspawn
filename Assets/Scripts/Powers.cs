using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    public GameObject Shields;
    public GameObject ShieldsUI;
    public GameObject TimerControl;
    public GameObject Ring;
    public GameObject HandheldWeapons;
    // Update is called once per frame

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shields.SetActive(true);
            ShieldsUI.SetActive(true);
            TimerControl.SetActive(true);
            TimerControl.GetComponent<TimerControl>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Ring.SetActive(true);
            HandheldWeapons.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Ring.SetActive(false);
            HandheldWeapons.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            HandheldWeapons.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            HandheldWeapons.SetActive(true);
        }
    }
}
