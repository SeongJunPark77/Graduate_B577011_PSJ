using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_final : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject mix;
    GameObject final;

    private AudioSource atk2audio;
    public AudioClip atk2_sound;

    public GameObject final_fade;
    void Awake()
    {
        mix = GameObject.Find("singlecanvas").transform.Find("mix").gameObject;
       final = GameObject.Find("singlecanvas").transform.Find("finalscroll").gameObject;

        this.atk2audio = this.gameObject.AddComponent<AudioSource>();
        this.atk2audio.clip = this.atk2_sound;
        this.atk2audio.loop = false;
        this.atk2audio.playOnAwake = false;
        this.atk2audio.volume = 0.9f;

        atk2audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(final.activeSelf==true)
        {
            mix.SetActive(false);
        }
    }

    public void clicked()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();

        final_fade.SetActive(true);
    }
}
