using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyIa : MonoBehaviour
{
    Camera _camera;
    [SerializeField] PoolEnemy _enemy;
    [SerializeField] Transform _transformA;
    [SerializeField] Transform _transformB;
    private GameObject enemy;
    [SerializeField] private GameObject lol;
    

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
           SpawnEnemy();
       }
       if (enemy != null)
       {
           enemy.transform.position = Vector3.Lerp(enemy.transform.position, _transformB.position, 0.02f);
       }
        
    }
    
    void SpawnEnemy()
    {
        enemy = _enemy.GetEnemy();
        enemy.SetActive(true);
        enemy.transform.position = _transformA.position;
    }
}
