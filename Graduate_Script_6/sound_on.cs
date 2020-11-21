using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_on : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject soundon;
    public GameObject soundoff;
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

        GameObject.Find("singlecanvas").GetComponent<AudioSource>().Play();
    }
}
