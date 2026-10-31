using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.CompareTag("Elements");
        TakeDamage(30);

        other.gameObject.CompareTag("Blade");
        TakeDamage(50);

        other.gameObject.CompareTag("ElementalBlade");
        TakeDamage(400);

        other.gameObject.CompareTag("Rings");
        TakeDamage(25);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
