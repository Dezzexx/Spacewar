using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float zBound = 20.0f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.z > zBound)
        {
            Destroy(gameObject);
        }
    }
}
