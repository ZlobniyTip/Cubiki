using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        StartCoroutine(Turning());
    }

    private IEnumerator Turning()
    {
        while (true)
        {
            transform.Rotate(0, _speed * Time.deltaTime, 0);
            yield return null;
        }
    }
}