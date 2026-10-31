using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform Spawnpoint;
    public int Rings;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        Ring();
    }

    // Update is called once per frame
    void Ring()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);

            clone.velocity = Spawnpoint.TransformDirection(Vector3.forward * 20);
        }
    }
}
