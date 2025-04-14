using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Camera _maincam;
    // [SerializeField] GameObject cible;

    private void Awake()
    {
        _maincam = Camera.main;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
          ShootMun();  
        }
    }

    void ShootMun()
    {
        Ray ray = _maincam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            Collider centerCible;
            centerCible = hit.collider;
            Vector3 centre = centerCible.bounds.center;
            float distance = Vector3.Distance(centre, hit.point);
            if (distance < 0.1f)
            {
                Debug.Log("it's amazing you shoot mid");
            }
            Debug.DrawLine(_maincam.transform.position, hit.point, Color.red);
        }
    }
}
