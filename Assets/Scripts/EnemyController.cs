using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private EnemyIndicator _enemyIndicator;
    
    private CubeController _controller;
    private float _speed = 2;

    // Start is called before the first frame update
    private void Start()
    {
        _controller = FindObjectOfType<CubeController>();
        _enemyIndicator = FindObjectOfType<EnemyIndicator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.GetComponent<BulletBehavior>())
        {
            
            Destroy(gameObject);
            _enemyIndicator.whenEnemyDied();
            Destroy(collision.gameObject); //разрушаем пулю
        }
    }
    private void Update()
    {
        var step = Time.deltaTime * _speed;
        transform.position = Vector3.MoveTowards(transform.position, _controller.transform.position, step);
        transform.LookAt(_controller.transform);
    }
}