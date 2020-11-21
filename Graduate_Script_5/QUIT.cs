using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void OnClick()
    {
        GameObject.Find("skip_sound").GetComponent<AudioSource>().Play();

        Application.Quit();
    }
}
