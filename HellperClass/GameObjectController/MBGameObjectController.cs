﻿using UnityEngine;

public class MBGameObjectController : MonoBehaviour, IGameObjectController
{
    public void Awake()
    {
        CharacterObject = gameObject;

        Direction = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBDirection>();
        Position = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBTransform>();
        Animator = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBAnimator>();
        Rotation = GameObject.FindGameObjectWithTag(gameObject.tag).GetComponent<MBRotation>();
    }

    public GameObject CharacterObject { private set; get; }

    public MBDirection Direction { private set; get; }
    public MBTransform Position { private set; get; }
    public MBAnimator Animator { private set; get; }
    public MBRotation Rotation { private set; get; }
}
