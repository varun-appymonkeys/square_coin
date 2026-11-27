using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationAngle = new Vector3(0, 0, 0);
    [SerializeField] private bool _continuouslyRotate = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HandleRotation();
    }

    // Update is called once per frame
    void Update()
    {
        if (_continuouslyRotate)
        {
            HandleRotation(Time.deltaTime);
        }
    }
    void HandleRotation(float _mul = 1f)
    {
        transform.Rotate(_rotationAngle * _mul);
    }
}
