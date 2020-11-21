using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volume_sfx : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider volume_array;
    public AudioSource back;
    public AudioSource back2;
    public AudioSource back3;
    public AudioSource back4;
    public AudioSource back5;

    private float vol = 1f;
    // Start is called before the first frame update
    private void Start()
    {
        vol = PlayerPrefs.GetFloat("vol", 1f);
        volume_array.value = vol;
        back.volume = volume_array.value;
        back2.volume = volume_array.value;
        back3.volume = volume_array.value;
        back4.volume = volume_array.value;
        back5.volume = volume_array.value;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void soundsli()
    {
        back.volume = volume_array.value;
        back2.volume = volume_array.value;
        back3.volume = volume_array.value;
        back4.volume = volume_array.value;
        back5.volume = volume_array.value;
        vol = volume_array.value;
        PlayerPrefs.SetFloat("vol", vol);
    }
}
