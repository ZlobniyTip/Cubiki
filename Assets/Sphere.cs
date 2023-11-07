using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Sphere : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(10,0,0), 3).SetLoops(-1, LoopType.Yoyo);
    }
}