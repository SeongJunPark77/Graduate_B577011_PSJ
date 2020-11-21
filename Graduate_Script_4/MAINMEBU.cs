using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMEBU : MonoBehaviour
{
    private AudioSource atkaudio;
    public AudioClip atk_sound;
    void Awake()
    {
        this.atkaudio = this.gameObject.AddComponent<AudioSource>();
        this.atkaudio.clip = this.atk_sound;
        this.atkaudio.loop = false;
        this.atkaudio.playOnAwake = false;
        this.atkaudio.volume = 0.9f;
    }
    // Start is called before the first frame update
    public void ChangeFirstScene()
    {
        atkaudio.Play();
        SceneManager.LoadScene("01.Title");
    }
}
