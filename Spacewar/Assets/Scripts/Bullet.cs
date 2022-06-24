using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float zBound = 20.0f;

    void FixedUpdate()
    {
        if (transform.position.z > zBound)
        {
            Destroy(gameObject);
        }
    }
}
