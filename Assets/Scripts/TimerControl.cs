using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerControl : MonoBehaviour
{
    public GameObject Shields;
    public GameObject ShieldsUI;
    public GameObject ThisControl;
    public float targetTime = 10.0f;

    void Start()
    {
        Update();
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Shields.SetActive(false);
            ShieldsUI.SetActive(false);
            ThisControl.SetActive(false);
            ThisControl.GetComponent<TimerControl>().enabled = false;
        }

        if (targetTime <= -0.001f)
        {
            targetTime = 10.0f;
        }
    }
}
