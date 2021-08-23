using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
 
    void Start()
    {
        
    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 20, -10);
    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
