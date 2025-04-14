using System;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
   [SerializeField]GameManager gameManager;
    Transform target;
   private void Start()
   {
      gameManager = GetComponent<GameManager>();
      target = gameManager.spawnPointB;
   }

   public void Move()
   {
       if (transform != null)
           transform.position = Vector3.Lerp(transform.position, target.position, 0.1f);
   }
}
