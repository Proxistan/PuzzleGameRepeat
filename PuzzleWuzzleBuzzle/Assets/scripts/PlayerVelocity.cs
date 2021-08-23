using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVelocity : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    [SerializeField]
    Vector3 speed;
    [SerializeField]
    KeyCode keyPlus; //keys to be selected in inspector, used this style as i just find it easier than the create with code examples
    [SerializeField]
    KeyCode keyMinus;

    void FixedUpdate()
    {
        if (Input.GetKey(keyPlus))
        GetComponent<Rigidbody>().velocity += speed; //increase speed one direction and other below

        if (Input.GetKey(keyMinus))
            GetComponent<Rigidbody>().velocity -= speed;

    }

    //private void onCollisionEnter(Collision collision other) //Couldnt quite get this to work
   // {
       // if (other.gameObject.CompareTag("trap"))
       // {
       //     Debug.Log("GAME OVER");
       //     gameOver = true;
       //     explosionParticle.Play();
       // }
   // }
}
