using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMen : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music.time = 9;
        music.Play();
    }
}
