using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GunShooting : MonoBehaviour
{
    [SerializeField] private BulletBehavior _bullet;
    [SerializeField] private float _speedBullet=38f;
    [SerializeField] private TextMeshProUGUI _text;

    private int OneShot=1;
    private int _bulletCount=20;
    // Start is called before the first frame update

    // Update is called once per frame
    
    void Update()
    {
        _text.text = _bulletCount.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            if (_bulletCount <= 0)
            {
                return;
            }
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _speedBullet;
            _bulletCount-=OneShot;


        }
    }
}