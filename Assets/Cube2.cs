using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _scaleChange;

    private Vector3 _scale;
    private Vector3 _maxScale;

    private void Start()
    {
        _scale = new Vector3(_scaleChange, _scaleChange, _scaleChange);
        _maxScale = new Vector3(3, 3, 3);
    }

    private void Update()
    {
        transform.position += transform.forward * _speed;
        transform.Rotate(0, _speedRotate * Time.deltaTime, 0);

        if (transform.localScale.x < _maxScale.x)
        {
            transform.localScale += _scale;
        }

    }
}
