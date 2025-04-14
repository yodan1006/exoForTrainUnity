using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Camera _maincam;
    [SerializeField] GameObject cible;
    private Collider centerCible;

    private void Awake()
    {
        _maincam = Camera.main;
    }

    private void Start()
    {
        centerCible = cible.GetComponent<Collider>();
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
        Vector3 mousePos = _maincam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 centre = centerCible.bounds.center;
        Ray ray = _maincam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            Debug.DrawLine(_maincam.transform.position, hit.point, Color.red);
        }
    }
}
