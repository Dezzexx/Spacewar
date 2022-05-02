using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 10.0f;
    private float _zBound = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        // Make it move.
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(horizontal, 0.0f, vertical);

        transform.Translate(_movement * Speed * Time.fixedDeltaTime);

        // Z bound.
        if (transform.position.z < -_zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -_zBound);

        }
        if (transform.position.z > _zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _zBound);
        }

    }
}
