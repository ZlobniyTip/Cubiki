using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _scaleChange;

    private Vector3 _scale;
    private Vector3 _maxScale;

    private void Start()
    {
        _scale = new Vector3(_scaleChange, _scaleChange, _scaleChange);
        _maxScale = new Vector3(4, 4, 4);
    }

    private void Update()
    {
        if (transform.localScale.x < _maxScale.x)
        {
            transform.localScale += _scale;
        }
    }
}
