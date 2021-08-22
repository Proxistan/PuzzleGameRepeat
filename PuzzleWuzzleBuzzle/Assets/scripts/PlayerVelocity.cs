using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 speed;
    [SerializeField]
    KeyCode keyPlus;
    [SerializeField]
    KeyCode keyMinus;

    void FixedUpdate()
    {
        if (Input.GetKey(keyPlus))
        GetComponent<Rigidbody>().velocity += speed;

        if (Input.GetKey(keyMinus))
            GetComponent<Rigidbody>().velocity -= speed;
    }
}
