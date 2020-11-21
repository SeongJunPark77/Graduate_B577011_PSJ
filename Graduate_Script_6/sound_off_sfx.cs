using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_off_sfx : MonoBehaviour
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
        soundon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void Cliced()
    {
        soundon.SetActive(true);
        soundoff.SetActive(false);

        back.volume = 0f;
        back2.volume = 0f;
        back3.volume = 0f;
        back4.volume = 0f;
        back5.volume = 0f;
        back6.volume = 0f;
        back7.volume = 0f;
    }
}
