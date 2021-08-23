using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    [SerializeField]
    Vector3 speed; // test script for initial player placement

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += speed;
    }
}
