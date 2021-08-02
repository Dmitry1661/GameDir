﻿using UnityEngine;

public class MBTransform : MonoBehaviour
{
    public void NextPosition(Vector3 pNextPosition)
    {
        Transform.position = pNextPosition;
    }

    private void Start()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody2D>();

        Transform = Rigidbody.transform;
    }

    private void Update()
    {
        Transform = Rigidbody.transform;
    }

    private Rigidbody2D Rigidbody { set; get; }

    public Transform Transform { private set; get; }
}
