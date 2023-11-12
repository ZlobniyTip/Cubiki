using System.Collections;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _rateChange;

    private Vector3 _scaleChange;
    private Vector3 _maxScale;

    private void Start()
    {
        _scaleChange = new Vector3(_rateChange, _rateChange, _rateChange);
        _maxScale = new Vector3(4, 4, 4);

        StartCoroutine(ScaleChange());
    }

    private IEnumerator ScaleChange()
    {
        while (transform.localScale.x < _maxScale.x)
        {
            transform.localScale += _scaleChange * Time.deltaTime;
            yield return null;
        }

    }
}
