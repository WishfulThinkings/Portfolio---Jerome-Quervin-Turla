using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBody : MonoBehaviour
{
    public PlayerMovementMagnet magnet;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        magnet.AttractTransform(this.transform);
    }
}
