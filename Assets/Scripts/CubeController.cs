using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _speed = 15;

    private int _pressW = 0;
    private int _pressS = 0;
    private float _currenttime;


    // Start is called before the first frame update


    private void Update()
    {
       
        var step = Time.deltaTime * _speed;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            _pressW++;
        }
        
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.3f, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.3f, 0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _pressS++;
        }
        
        
        if (_pressW > 0)
        {
            transform.Translate(0, 0, step, transform);
        }
        
        if (_pressS > 0)
        {
            transform.Translate(0, 0, -step, transform);
        }
        
        
        _pressW = 0;
        _pressS = 0;
    }
}