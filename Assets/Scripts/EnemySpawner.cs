using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabEnemy;
    public int _countEnemy=5;
    
    // Start is called before the first frame update
    void Start()
    {
        
         
        for (int i = 0; i < _countEnemy; i++)
        {
            var newEnemy = Instantiate(_prefabEnemy);
            newEnemy.transform.position = new Vector3(Random.Range(-40, 40), 0.1f, Random.Range(60, -50));
        }
        
    }
    

   
}