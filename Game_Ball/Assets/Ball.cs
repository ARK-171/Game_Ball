using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour
{
    public Collider col;

    private void Start()
    {
        col.attachedRigidbody.useGravity = true;
    }

}
