using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public GameObject HandheldWeapons;
    public GameObject Rings;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Powers();
        MagicFight();
        SwordFight();
    }
    void Powers()
    {
        if (HandheldWeapons.activeInHierarchy == false)
        {
            if (Rings.activeInHierarchy == false)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    anim.SetInteger("Condition", 4);
                }

                if (Input.GetKeyUp(KeyCode.W))
                {
                    anim.SetInteger("Condition", 0);
                }

                if (Input.GetKey(KeyCode.S))
                {
                    anim.SetInteger("Condition", 5);
                }

                if (Input.GetKeyUp(KeyCode.S))
                {
                    anim.SetInteger("Condition", 0);
                }

                if (Input.GetMouseButton(0))
                {
                    anim.SetInteger("Condition", 6);
                }
            }
        }
    }

    void SwordFight()
    {
        if (HandheldWeapons.activeInHierarchy == true)
        {
            if (Rings.activeInHierarchy == false)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    anim.SetInteger("Condition", 1);
                }

                if (Input.GetKeyUp(KeyCode.W))
                {
                    anim.SetInteger("Condition", 0);
                }

                if (Input.GetKey(KeyCode.S))
                {
                    anim.SetInteger("Condition", 2);
                }

                if (Input.GetKeyUp(KeyCode.S))
                {
                    anim.SetInteger("Condition", 0);
                }

                if (Input.GetMouseButton(0))
                {
                    anim.SetInteger("Condition", 3);
                }
            }
        }
    }

    void MagicFight()
    {
        if (HandheldWeapons.activeInHierarchy == false)
        {
            if (Rings.activeInHierarchy == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    anim.SetInteger("Condition", 8);
                }

                if (Input.GetKeyUp(KeyCode.W))
                {
                    anim.SetInteger("Condition", 0);
                }

                if (Input.GetKey(KeyCode.S))
                {
                    anim.SetInteger("Condition", 9);
                }

                if (Input.GetKeyUp(KeyCode.S))
                {
                    anim.SetInteger("Condition", 0);
                }
            }
        }
    }

}
