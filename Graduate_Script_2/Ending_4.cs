using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending_4 : MonoBehaviour
{
    // Start is called before the first frame update
    int talkCnt = 27;       // 대화의 총 갯수를 설정해줍니다.
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
        charactors[7] = GameObject.Find("Canvas").transform.Find("monster2").GetComponent<Image>();
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

        if (strCnt == 26)
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
        talking[0] = "'여기인가?'";
        talking[1] = "'벌써 여길 찾아낸건가...'";
        talking[2] = "'이봐 잠시만, 우린 싸울 필요가 아예 없어'";
        talking[3] = "'무슨 소리야?'";
        talking[4] = "'마왕의 부하들은 저희가 다 무찔렀어요. 이제 마을로 돌아가도 돼요'";
        talking[5] = "'그..그게 정말입니까...?'";
        talking[6] = "'그렇다면 너가 그 용사..?'";

        talking[7] = "'맞아, 중간에 함정에 걸려 너를 해치러 올 뻔 했지만 모든게 잘 풀렸어'";
        talking[8] = "'정말 다행이다.. 싸우는건 자신 없어서 무서웠는데'";
        talking[9] = "'마을 주민분들과 이제 마을로 돌아가시면 돼요. 이제 마을에 마왕의 부하들은 없어요.'";
        talking[10] = "'정말 감사합니다...'";
        talking[11] = "'그 혹시 부탁하나만 들어줄 수 있어?'";
        talking[12] = "'당연하지, 뭔데?'";
        talking[13] = "'우린 지금 마왕의 저주에 걸려있어, 그 저주를 이 마을에서 풀 수 있다는 소문을 듣고 여기 온거야'";
        talking[14] = "'음 어쩐지 하나의 몸에서 여러명이 느껴지더라니 강력한 저주가 걸려있네, '";
        talking[15] = "'풀 수 있겠어?'";
        talking[16] = "'조금 어려운 저주긴 하지만 나라면 가능해. 서 있어봐'";
        talking[17] = "";
        talking[18] = "'저주가...!'";
        talking[19] = "'드디어 저주가 풀렸어...'";
        talking[20] = "'정말 감사해요'";
        talking[21] = "'아냐 마을을 구해준 내가 더 고마워'";
        talking[22] = "'다시 마족이나 마물들이 쳐들어오면 말해. 우리가 바로 도와주러 갈테니'";
        talking[23] = "'그래.. 만나서 반가웠어 기회가 되면 다시 보자'";
        talking[24] = "-용사는 저주에서 벗어났고, 마을은 평화를 되찾았다-";
        talking[25] = "-HAPPY ENDING-";
        talking[26] = "";
        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 4;     // 적
        showCnt[1] = 0;
        showCnt[2] = 2;
        showCnt[3] = 0;
        showCnt[4] = 1;
        showCnt[5] = 7;
        showCnt[6] = 0;
        showCnt[7] = 2;     // 적
        showCnt[8] = 0;
        showCnt[9] = 1;
        showCnt[10] = 7;
        showCnt[11] = 4;
        showCnt[12] = 0;
        showCnt[13] = 4;
        showCnt[14] = 0;     // 적
        showCnt[15] = 3;
        showCnt[16] = 0;
        showCnt[17] = 6;
        showCnt[18] = 5;
        showCnt[19] = 2;
        showCnt[20] = 1;
        showCnt[21] = 0;
        showCnt[22] = 2;
        showCnt[23] = 0;
        showCnt[24] = 8;
        showCnt[25] = 8;
        showCnt[26] = 8;

        // 순서로 이루어지는 대화
    }
}
