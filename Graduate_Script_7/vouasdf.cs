using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vouasdf : MonoBehaviour
{
    public Slider volume_array;
    public AudioSource back;
    public AudioSource back2;

    GameObject zz;

    private float vol = 1f;
    // Start is called before the first frame update
    void Start()
    {
        zz= GameObject.Find("singlecanvas").transform.Find("back_volum").gameObject;
        zz.SetActive(false);

        vol = PlayerPrefs.GetFloat("vol", 1f);
        volume_array.value = vol;
        back.volume = volume_array.value;
        back2.volume = volume_array.value;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void soundsli()
    {
        back.volume = volume_array.value;
        back2.volume = volume_array.value;

        vol = volume_array.value;
        PlayerPrefs.SetFloat("vol", vol);
    }
}
