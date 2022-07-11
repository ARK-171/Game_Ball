using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject ball;
    public GameObject trap;
    Quaternion q;

    private void Start()
    {
        q = trap.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = new Vector3(0, 4, 0);
        trap.transform.rotation = q;
    }
}
