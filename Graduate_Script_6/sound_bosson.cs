using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_bosson : MonoBehaviour
{
    public GameObject soundon;
    public GameObject soundoff;

    public AudioSource back;
    public AudioSource back2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clicked()
    {
        soundon.SetActive(false);
        soundoff.SetActive(true);

        back.Play();
        back2.Play();
    }
}
