using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodEdit : MonoBehaviour
{

    bool godskilluse = true;
    bool godskilluse2 = true;

    public ParticleSystem Icebomb;
    public ParticleSystem Snowrain;
    public GameObject me;

    public GameObject hitbox;
    public GameObject hitbox2;
    public GameObject attackbox;
    public GameObject attackbox2;

    private AudioSource atkaudio;
    public AudioClip atk_sound;

    private AudioSource atkaudio2;
    public AudioClip atk_sound2;

    // Start is called before the first frame update
    void Awake()
    {
        this.atkaudio = this.gameObject.AddComponent<AudioSource>();
        this.atkaudio.clip = this.atk_sound;
        this.atkaudio.loop = false;
        this.atkaudio.playOnAwake = false;
        this.atkaudio.volume = 0.55f;

        this.atkaudio2 = this.gameObject.AddComponent<AudioSource>();
        this.atkaudio2.clip = this.atk_sound2;
        this.atkaudio2.loop = false;
        this.atkaudio2.playOnAwake = false;
        this.atkaudio2.volume = 0.55f;

        Icebomb.gameObject.SetActive(false);
        Snowrain.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        Keydown();

        //godpoint God = GameObject.Find("godpoint").GetComponent<godpoint>();
        if (godpoint.god_point >= 5&& godpoint.god_point<10)
        {
            godskilluse = true;
        }
        else
        {

            godskilluse = false;
        }

        if (godpoint.god_point == 10)
        {
            godskilluse2 = true;
        }
        else
        {

            godskilluse2 = false;
        }
    }

    void Keydown()
    {

        //godpoint God = GameObject.Find("godpoint").GetComponent<godpoint>();

        if (Input.GetMouseButtonDown(2))
        {
            
            if (godskilluse)
            {
               

                Instantiate(hitbox, attackbox.transform.position, attackbox2.transform.rotation);
                atkaudio.Play();
                Icebomb.transform.position = me.transform.position;
                Icebomb.gameObject.SetActive(true);
                Icebomb.Play();
                for (int i = 0; i < 5; i++)
                {
                    godpoint.god_point--;
                }

            }

        }

     

        if (Input.GetMouseButtonDown(2))
        {
            if (godskilluse2)
            {          
              Instantiate(hitbox2, attackbox.transform.position+new Vector3(0,0,0), attackbox2.transform.rotation);
                atkaudio2.Play();
                Snowrain.transform.position = me.transform.position;
                Snowrain.gameObject.SetActive(true);
                Snowrain.Play();
                
                for (int i = 0; i < 10; i++)
                {
                    godpoint.god_point--;
                }
            }
        }
    }
}
