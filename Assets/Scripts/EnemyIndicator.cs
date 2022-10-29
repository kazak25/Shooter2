using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyIndicator : MonoBehaviour
{
    [SerializeField] private Image _imagePrefab;
    
    private List<Image> _images = new List<Image>();
    private int _howMuchEnemyDied;  //сколько врагов убито
    private EnemySpawner _enemySpawner;
    private int _countEnemy;


    // Start is called before the first frame update
    void Start()
    {
        _enemySpawner = FindObjectOfType<EnemySpawner>();
        _countEnemy = _enemySpawner._countEnemy;
        for (int i = 0; i < _countEnemy; i++)
        {
            var prefab = Instantiate(_imagePrefab, transform);
            _images.Add(prefab);
        }
    }

    public void whenEnemyDied()
    {
        Destroy(_images[_countEnemy - 1 - _howMuchEnemyDied]);
        _howMuchEnemyDied++;
    }


    // Update is called once per frame
}