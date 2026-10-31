using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject NPCText;
    public GameObject CursorControl;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.CompareTag("Player");
        NPCText.SetActive(true);
        CursorControl.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.CompareTag("Player");
        NPCText.SetActive(false);
        CursorControl.SetActive(true);
    }
    public void Exit()
    {
        NPCText.SetActive(false);
        CursorControl.SetActive(true);
    }
}
