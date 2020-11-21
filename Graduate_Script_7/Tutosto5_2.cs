using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutosto5_2 : MonoBehaviour
{
    // Start is called before the first frame update
    int talkCnt = 8;       // 대화의 총 갯수를 설정해줍니다.
    int strCnt = 0;         // 이 변수가 하나씩 커져가면서 대화를 진행합니다.
    string[] talking;          // 대화 내용을 저장할 공간입니다.
    public Text txt;        // Text 오브젝트에 접근하기
    public Image[] charactors;
    public Image showText;
    int[] showCnt;
    // Start is called before the first frame update
    void Start()
    {
        talking = new string[talkCnt]; // 대화 저장 공간을 초기화해줍니다.
        showCnt = new int[talkCnt];
        txt = GameObject.Find("Canvas").transform.Find("ttext").GetComponent<Text>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 Text를 호출합니다.
        showText = GameObject.Find("Canvas").transform.Find("talkScreen").GetComponent<Image>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 talkScreen을 호출합니다.

        charactors = new Image[6];  // 이미지 호출할 배열을 만듭니다.  // 적
        charactors[0] = GameObject.Find("Canvas").transform.Find("monster").GetComponent<Image>();
        charactors[1] = GameObject.Find("Canvas").transform.Find("warlord").GetComponent<Image>();
        charactors[2] = GameObject.Find("Canvas").transform.Find("wizard").GetComponent<Image>();
        charactors[3] = GameObject.Find("Canvas").transform.Find("archer").GetComponent<Image>();
        charactors[4] = GameObject.Find("Canvas").transform.Find("god").GetComponent<Image>();// 서포트
        charactors[5] = GameObject.Find("Canvas").transform.Find("nothing").GetComponent<Image>();
        // 각 배열에 오브젝트를 연결합니다.
        // 등장 인물이 많다면 여러개를 생성해야 합니다.

        initialized();      // 대화를 설정하는 함수입니다.
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0.0f;
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
            strCnt++;

            // '엔터'나 '스페이스바'를 누르면 카운트가 올라갑니다.
        }

        if (strCnt == 7)
        {
            Time.timeScale = 1.0f;

            SceneManager.UnloadSceneAsync("Tuto_sto5-2");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


        showAll();

    }

    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 6; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
        {
            charactors[i].gameObject.SetActive(false);      // 모든 오브젝트를 비활성화합니다.(사람 이미지)
        }
        charactors[showCnt[strCnt]].gameObject.SetActive(true);
        // 캐릭터의 showCnt라는 배열의 숫자에 대한 오브젝트만을 활성화합니다.
        txt.text = talking[strCnt];
        // strCnt의 차례에 맞춰 대화를 출력합니다.
    }

    void initialized()
    {
        // 대화 내용을 하나하나 추가합니다.
        talking[0] = "'크르륵...인간..약하군...'";
        talking[1] = "'이녀석 너무 맷집이 좋은데?'";
        talking[2] = "'우리 이런데서 낭비할 시간이 없어요 특수기를 써요'";
        talking[3] = "'그 기술을? 넷이서 힘을 합쳐도 겨우 쓴 기술인데 지금 가능할까?'";
        talking[4] = "'저주 때문에 하나로 합쳐져서 자주는 못쓰겠지만 가능은 할거계요'";
        talking[5] = "'좋아 그럼 해보자'";
        talking[6] = "";
        talking[7] = "";

        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 적
        showCnt[1] = 1;
        showCnt[2] = 2;
        showCnt[3] = 3;
        showCnt[4] = 2;
        showCnt[5] = 1;
        showCnt[6] = 4;
        showCnt[7] = 5;// 주인공

        // 순서로 이루어지는 대화
    }
}
