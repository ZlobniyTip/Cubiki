using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scaleChange;

    private Vector3 _scaleAllAxes;
    private Vector3 _maxScale;

    private void Start()
    {
        _scaleAllAxes = new Vector3(_scaleChange, _scaleChange, _scaleChange);
        _maxScale = new Vector3(4, 4, 4);
    }

    private void Update()
    {
        if (transform.localScale.x < _maxScale.x)
        {
            transform.localScale += _scaleAllAxes;
        }
    }
}
