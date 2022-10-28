using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    [SerializeField] private BulletBehavior _bullet;
    [SerializeField] private float _speedBullet=38f;
    // Start is called before the first frame update

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _speedBullet;
            

        }
    }
}