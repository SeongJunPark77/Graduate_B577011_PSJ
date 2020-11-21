using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ending_1 : MonoBehaviour
{
    // Start is called before the first frame update
    int talkCnt = 21;       // 대화의 총 갯수를 설정해줍니다.
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

        charactors = new Image[9];  // 이미지 호출할 배열을 만듭니다.  // 적
        charactors[0] = GameObject.Find("Canvas").transform.Find("monster1").GetComponent<Image>();
        charactors[1] = GameObject.Find("Canvas").transform.Find("wizard1").GetComponent<Image>();
        charactors[2] = GameObject.Find("Canvas").transform.Find("knight1").GetComponent<Image>();
        charactors[3] = GameObject.Find("Canvas").transform.Find("warlord1").GetComponent<Image>();
        charactors[4] = GameObject.Find("Canvas").transform.Find("archer1").GetComponent<Image>();
        charactors[5] = GameObject.Find("Canvas").transform.Find("allcha").GetComponent<Image>();
        charactors[6] = GameObject.Find("Canvas").transform.Find("cut1").GetComponent<Image>();
        charactors[7] = GameObject.Find("Canvas").transform.Find("cut2").GetComponent<Image>();
        charactors[8] = GameObject.Find("Canvas").transform.Find("nothing1").GetComponent<Image>();
        // 각 배열에 오브젝트를 연결합니다.
        // 각 배열에 오브젝트를 연결합니다.
        // 등장 인물이 많다면 여러개를 생성해야 합니다.

        initialized();      // 대화를 설정하는 함수입니다.
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 0.0f;
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
            strCnt++;

            // '엔터'나 '스페이스바'를 누르면 카운트가 올라갑니다.
        }

        if (strCnt == 20)
        {
            //Time.timeScale = 1.0f;

            //SceneManager.UnloadSceneAsync("final_stor2");
            SceneManager.LoadScene("End");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


        showAll();

    }

    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 9; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
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
        talking[0] = "'하아... 여기 까지 인가'";
        talking[1] = "'잠깐!! 멈춰봐!'";
        talking[2] = "'무슨 속셈이지?'";
        talking[3] = "'속셈같은건 없어, 이걸 봐'";
        talking[4] = "";
        talking[5] = "'...! 이건 우리 닐슨 할아버지가 대피하면서 잃어버렸다던 일기?'";
        talking[6] = "'다행히 알아보는군, 그래 우리끼리 싸울 이유가 전혀 없어 모든건 마왕의 수작질이었지'";

        talking[7] = "'그렇다면 너가 용사...?'";
        talking[8] = "'그래, 우린 마왕에게 저주에 걸렸고, 그걸 풀기 위해 너를 찾아온거야'";
        talking[9] = "'어쩐지 혼자인게 분명한데 안에 여러명이 느껴진다더니.. 좋아 저주를 풀어주지 대신, 조건이 있어'";
        talking[10] = "'뭔데? 말해봐'";
        talking[11] = "'저주를 풀어줄테니 마을 안과 근처에 남아있는 마왕의 부하들을 무찔러줘'";
        talking[12] = "'저주만 풀어준다면 당연히 해줄 수 있지'";
        talking[13] = "'좋아 그럼 간다...!'";
        talking[14] = "";
        talking[15] = "'저주가...!'";
        talking[16] = "'드디어 저주가 풀렸어요! 약속은 바로 지켜드릴게요!'";
        talking[17] = "'저주가 풀린건 기쁘지만 마을 앞에 있던 그 영감은 대체..?'";
        talking[18] = "-이후 저주가 풀린 용사들은 마을의 평화를 되찾아주고 본인들도 일상으로 돌아갔다-";
        talking[19] = "-NORMAL ENDING-";
        talking[20] = "";
        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 적
        showCnt[1] = 2;
        showCnt[2] = 0;
        showCnt[3] = 2;
        showCnt[4] = 6;
        showCnt[5] = 0;
        showCnt[6] = 2;
        showCnt[7] = 0;     // 적
        showCnt[8] = 4;
        showCnt[9] = 0;
        showCnt[10] = 3;
        showCnt[11] = 0;
        showCnt[12] = 4;
        showCnt[13] = 0;
        showCnt[14] = 7;     // 적
        showCnt[15] = 5;
        showCnt[16] = 1;
        showCnt[17] = 2;
        showCnt[18] = 8;
        showCnt[19] = 8;
        showCnt[20] = 8;

        // 순서로 이루어지는 대화
    }
}
