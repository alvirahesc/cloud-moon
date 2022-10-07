using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public GameObject audioObj;

    public void PutInAudio()
    {
        Instantiate(audioObj, transform.position, transform.rotation);
    }
}
