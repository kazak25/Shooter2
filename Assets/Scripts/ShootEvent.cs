using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootEvent : MonoBehaviour
{
    
    [SerializeField] private UnityEvent <float> _shootEvent;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _shootEvent.Invoke(1);
        }
    }
}
