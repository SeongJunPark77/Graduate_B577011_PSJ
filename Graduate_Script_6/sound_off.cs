using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_off : MonoBehaviour
{
    // Start is called before the first frame update
 

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
    public void Clicked()
    {
        soundon.SetActive(true);
        soundoff.SetActive(false);

        GameObject.Find("singlecanvas").GetComponent<AudioSource>().Pause();

    }
}
