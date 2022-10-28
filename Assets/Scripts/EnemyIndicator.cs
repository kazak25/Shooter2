using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyIndicator : MonoBehaviour
{
    [SerializeField] private Image _imagePrefab;
    private List<Image> _images = new List<Image>();
    private int _countEnemy = 5; //количество врагов
    private int _howMuchEnemyDied;  //сколько врагов убито


    // Start is called before the first frame update
    void Start()
    {
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