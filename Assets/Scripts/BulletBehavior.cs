using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody _rigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.useGravity = true;
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
