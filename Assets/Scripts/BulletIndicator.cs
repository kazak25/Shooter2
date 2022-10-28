using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BulletIndicator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    
    private float _bulletCount = 20;

    public void Shoot(float num)
    {
        if (_bulletCount <= 0)
        {
            return;
        }

        _bulletCount -= num;
    }
    public float NumberOfShots()
    {
        return _bulletCount;
    }
    private void Update()
    {
        _text.text = _bulletCount.ToString();
    }
}