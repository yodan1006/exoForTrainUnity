using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public GameObject CiblePrefab;
    public float timeForSpawn = 5f;
    private float timereset = 5f;


    private void Update()
    {
        timeForSpawn -= Time.deltaTime;
        if (timeForSpawn <= 0)
        {
            timeForSpawn = timereset;
            CircleSpawn();
        }
    }

    public void CircleSpawn()
    {
        GameObject circle = Instantiate(CiblePrefab);

        if (circle != null)
        {
            Vector3 pos = GetRandomPos();
            circle.transform.position = pos;
            circle.GetComponent<EnemyIa>().Move();
        }
    }
    
    private Vector3 GetRandomPos()
    {
        var randomX = Random.Range(spawnPoint1.position.x, spawnPoint2.position.x);
        var randomY = spawnPoint1.position.y;
        var randomZ = spawnPoint1.position.z;
        
        return new Vector3(randomX, randomY, randomZ);
    }
}
