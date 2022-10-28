using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GunShooting : MonoBehaviour
{
    [SerializeField] private BulletBehavior _bullet;
    [SerializeField] private float _speedBullet = 38f;
    [SerializeField] private BulletIndicator _bulletIndicator;
    void Update()
    {
        //_text.text = _bulletCount.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            if (_bulletIndicator.NumberOfShots() <= 0)
            {
                return;
            }
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _speedBullet;
            // _bulletCount-=OneShot;
        }
    }
}