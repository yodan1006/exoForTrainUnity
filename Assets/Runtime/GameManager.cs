using System;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefabEnemy;
    [SerializeField] private float _timeToSpawn = 5f;
    [SerializeField] private Transform _spawnPointA;
    [SerializeField] public Transform spawnPointB;
    private void Update()
    {
        _timeToSpawn -= Time.deltaTime;
        if (_timeToSpawn <= 0)
        {
            Instantiate(_prefabEnemy);
            _timeToSpawn = 5f;
        }
    }
}
