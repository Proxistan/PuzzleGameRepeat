using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // if player falls destroy player
    void Start()
    {
        
    }

    private float topBound = 1000;
    private float lowerBound = -1000; //set this high due to multiple scenes being on different y and x axis Learning experience!
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);

        }
    }
}
