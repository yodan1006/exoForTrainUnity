using System;
using UnityEngine;

public class EnemyIa : MonoBehaviour
{
    Rigidbody myrigidbody;

    private void Start()
    {
        myrigidbody = this.GetComponent<Rigidbody>();
    }

    public void Move()
    {
        myrigidbody = this.GetComponent<Rigidbody>();
        myrigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }

}
