using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float lifetime = 3.0f;

    public void DestroyExplosion()
    { Destroy(gameObject, lifetime); }
}
