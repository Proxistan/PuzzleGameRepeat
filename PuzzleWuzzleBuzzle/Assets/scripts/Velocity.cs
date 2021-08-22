using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    [SerializeField]
    Vector3 speed;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += speed;
    }
}
