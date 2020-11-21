using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aaa4 : MonoBehaviour
{
    public GameObject archer_alpha;
    public GameObject wizard_alpha;
    public GameObject knight_alpha;
    public GameObject warlord_alpha;
    // Start is called before the first frame update
    public ParticleSystem summon;
    public GameObject me;

    public Image image;
    public Image image1;
    public Image image2;
    public Image image3;

    public Image Hpbar;
    public Image Hpbar2;
    public Image Hpbar3;
    public Image Hpbar4;

    public Image Mpbar;
    public Image Mpbar2;
    public Image Mpbar3;
    public Image Mpbar4;

    public GameObject picture;
    public GameObject picture2;
    public GameObject picture3;
    public GameObject picture4;

    public Button button;
    public Button button1;
    public Button button2;
    public Button button3;
    public float coolTime = 10.0f;
    public bool isClicked = false;
    float leftTime = 10.0f;
    float speed = 6.0f;

    public Transform bigboss;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    private bool spawnCheck = false;

    public Image cutsc;
    Image Cubeobject;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && isClicked == false && button3.enabled == true)
        {
            OnButtonClick();
        }

        summon.transform.position = me.transform.position;

        if (isClicked)
            if (leftTime > 0)
            {
                leftTime -= Time.deltaTime * speed;
                if (leftTime < 0)
                {
                    leftTime = 0;
                    if (button)
                        button.enabled = true;
                    if (button1)
                        button1.enabled = true;
                    if (button2)
                        button2.enabled = true;
                    //if (button3)
                    //    button3.enabled = true;
                    isClicked = false;
                }

                float ratio = 1.0f - (leftTime / coolTime);
                if (image)
                    image.fillAmount = ratio;
                if (image1)
                    image1.fillAmount = ratio;
                if (image2)
                    image2.fillAmount = ratio;
                //if (image3)
                //    image3.fillAmount = ratio;
            }
    }

    public void OnButtonClick()
    {
        archer_alpha.SetActive(false);
        wizard_alpha.SetActive(false);
        knight_alpha.SetActive(false);
        warlord_alpha.SetActive(true);

        GameObject.Find("change_sound").GetComponent<AudioSource>().Play();
        summon.gameObject.SetActive(true);
        summon.Play();

        cutsc.transform.SetParent(GameObject.Find("UI").transform, false);

        Cubeobject = (Image)Instantiate(cutsc, new Vector3(1100f, 260f, 0), transform.rotation);

        Destroy(Cubeobject.gameObject, 1.5f);

        leftTime = coolTime;
        isClicked = true;
        if (button)
            button.enabled = false;
        if (button1)
            button1.enabled = false;
        if (button2)
            button2.enabled = false;
        if (button3)
            button3.enabled = false;

        Hpbar.gameObject.SetActive(false);
        Hpbar2.gameObject.SetActive(false);
        Hpbar3.gameObject.SetActive(false);
        Hpbar4.gameObject.SetActive(true);

        picture.SetActive(false);
        picture2.SetActive(false);
        picture3.SetActive(false);
        picture4.SetActive(true);

        Mpbar.gameObject.SetActive(false);
        Mpbar2.gameObject.SetActive(false);
        Mpbar3.gameObject.SetActive(false);
        Mpbar4.gameObject.SetActive(true);

        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(true);
        player4.transform.position = bigboss.transform.position;
        if (spawnCheck)
            return;
        spawnCheck = true;

    }
    // Update is called once per frame

    public void Spawn()
    {
        // 사용기능
        spawnCheck = false;
    }
}
