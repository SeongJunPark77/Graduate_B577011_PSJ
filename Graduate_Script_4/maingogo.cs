using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class maingogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onbuttonclick()
    {
        GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("01.Title");
    }
}
