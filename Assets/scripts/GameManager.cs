using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //aaa
    }
}

public class PlayAudio : MonoBehaviour
{
    public AudioSource mySource;
    public AudioClip musicsfx;
    public float volume = 0.5f;

    void Start()
    {
        mySource.PlayOneShot(musicsfx, volume);
    }
}