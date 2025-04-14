using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PoolEnemy : MonoBehaviour
{
    [SerializeField] GameObject PrefabEnemy;
    [SerializeField] private int numberPool = 100;
    
    public List<GameObject> Enemies;

    private void Awake()
    {
        Enemies = new List<GameObject>();

        for (int i = 0; i < numberPool; i++)
        {
            GameObject enemy = Instantiate(PrefabEnemy, transform);
            enemy.SetActive(false);
            Enemies.Add(enemy);
        }
    }

    public GameObject GetEnemy()
    {
        List<GameObject> inactiveEnemies = new List<GameObject>();

        foreach (var enemy in Enemies)
        {
            if (!enemy.activeInHierarchy)
            {
                enemy.SetActive(true);
                return enemy;
            }
        }

        GameObject newEnemy = Instantiate(PrefabEnemy, transform);
        newEnemy.SetActive(true);
        Enemies.Add(newEnemy);
        return newEnemy;
    }
}
