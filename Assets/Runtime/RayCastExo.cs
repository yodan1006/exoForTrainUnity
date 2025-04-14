using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayCastExo : MonoBehaviour
{
    Camera cam;
    [SerializeField] private LayerMask _layerMask;
    
    [SerializeField]private GameObject cube;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity,_layerMask))
        {
            Debug.DrawLine(cam.transform.position, hit.point, Color.red);
            cube.transform.position = Vector3.Lerp(cube.transform.position, hit.point, 0.01f);
            cube.transform.rotation = Quaternion.LookRotation(hit.point - cube.transform.position);
        }
    }
}