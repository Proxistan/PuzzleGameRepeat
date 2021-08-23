using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAlert : MonoBehaviour
{
    public AudioSource Alert;

    public void PlayAlert1() //play alert for button presses
    {
        Alert.Play();
    }
}
