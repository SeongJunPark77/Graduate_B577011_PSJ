using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_on_sfx : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource back;
    public AudioSource back2;
    public AudioSource back3;
    public AudioSource back4;
    public AudioSource back5;
    public AudioSource back6;
    public AudioSource back7;

    public GameObject soundon;
    public GameObject soundoff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void Cliced()
    {
        soundon.SetActive(false);
        soundoff.SetActive(true);

        back.volume = 0.25f;
        back2.volume = 0.3f;
        back3.volume = 1f;
        back4.volume = 1f;
        back5.volume = 0.33f;
        back6.volume = 0.7f;
        back7.volume = 0.95f;
    }
}
