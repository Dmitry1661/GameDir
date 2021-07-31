﻿using UnityEngine;

public class MBController : MonoBehaviour, IController
{
    public void Start()
    {
        CharacterObject = gameObject;

        Direction = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBDirection>();
        Position = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBTransform>();
        Animation = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBAnimation>();
    }

    public GameObject CharacterObject { private set; get; }
    public MBDirection Direction { private set; get; }
    public MBTransform Position { private set; get; }
    public MBAnimation Animation { private set; get; }
}
