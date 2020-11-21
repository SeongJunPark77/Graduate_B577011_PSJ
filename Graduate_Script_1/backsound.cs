using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backsound : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource atkaudio;
    public AudioClip atk_sound;


    void Start()
    {
        this.atkaudio = this.gameObject.AddComponent<AudioSource>();
        this.atkaudio.clip = this.atk_sound;
        this.atkaudio.loop = true;
        this.atkaudio.playOnAwake = true;
        this.atkaudio.volume = 0.6f;

        
    }

    // Update is called once per frame
    void Update()
    {
        //witch_main music = GameObject.Find("Witch01").GetComponent<witch_main>();
        //if (music.hp <= 1200)
        //{
        //    GameObject.Find("back_sound").GetComponent<AudioSource>().Stop();
        //    atkaudio.Play();
        //    //atkaudio.Stop();

        //}
    }
}
