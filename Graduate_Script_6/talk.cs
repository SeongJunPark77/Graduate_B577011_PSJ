using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class talk : MonoBehaviour
{
    int talkCnt = 11;       // 대화의 총 갯수를 설정해줍니다.
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
        txt = GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 Text를 호출합니다.
        showText = GameObject.Find("Canvas").transform.Find("talkScreen").GetComponent<Image>();
        // 캔버스 오브젝트 아래 자식 오브젝트로 있는 talkScreen을 호출합니다.

        charactors = new Image[11];  // 이미지 호출할 배열을 만듭니다.
        charactors[0] = GameObject.Find("Canvas").transform.Find("story1").GetComponent<Image>();  // 주인공
        charactors[1] = GameObject.Find("Canvas").transform.Find("story2").GetComponent<Image>();  // 적
        charactors[2] = GameObject.Find("Canvas").transform.Find("story3").GetComponent<Image>();   // 서포트
        charactors[3] = GameObject.Find("Canvas").transform.Find("story4").GetComponent<Image>();  // 주인공
        charactors[4] = GameObject.Find("Canvas").transform.Find("story5").GetComponent<Image>();  // 적
        charactors[5] = GameObject.Find("Canvas").transform.Find("story6").GetComponent<Image>();
        charactors[6] = GameObject.Find("Canvas").transform.Find("story7").GetComponent<Image>();  // 주인공
        charactors[7] = GameObject.Find("Canvas").transform.Find("story8").GetComponent<Image>();  // 적
        charactors[8] = GameObject.Find("Canvas").transform.Find("story9").GetComponent<Image>();
        charactors[9] = GameObject.Find("Canvas").transform.Find("story10").GetComponent<Image>();  // 주인공
        charactors[10] = GameObject.Find("Canvas").transform.Find("nothing").GetComponent<Image>();  // 적
       // 각 배열에 오브젝트를 연결합니다.
                                                                                                      // 등장 인물이 많다면 여러개를 생성해야 합니다.

        initialized();      // 대화를 설정하는 함수입니다.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Jump"))
        {
            GameObject.Find("exit_sound").GetComponent<AudioSource>().Play();
            strCnt++;
            
            // '엔터'나 '스페이스바'를 누르면 카운트가 올라갑니다.
        }

        if (strCnt == 10)
        {
            SceneManager.LoadScene("02.Tutorial");
        }


        showAll();

    }

    void showAll()
    {
        showText.gameObject.SetActive(true);
        for (int i = 0; i < 11; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
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
        talking[0] = "마왕이 나타났고, 세상은 혼란에 빠졌다.";
        talking[1] = "하지만 언제나 그렇듯이 용사들은 등장했다.";
        talking[2] = "용사들과 마왕의 싸움은 치열했으나 승기는 점점 용사들에게 기울었다.";
        talking[3] = "그러나 마왕은 죽기 직전 용사들에게 저주를 내렸고,용사들은 한 몸에 갇히는 저주에 걸렸다.";
        talking[4] = "용사는 저주를 풀기 위해 수소문을 하러 다녔고";
        talking[5] = "이윽고 저주를 풀 수 있다는 마을 '조치원'을 찾게 되었다.";
        talking[6] = "하지만 마을에 도착했을 때, 마을에 사람은 아무도 없고 괴물들이 돌아다니고 있었다.";
        talking[7] = "마을을 수색하던 도중 쓰러져 있는 한 노인을 발견하였다.";
        talking[8] = "그는 마을에 눈의 마녀가 괴물들을 부리며 나타나 마을을 습격하였고,\n 마을 사람들을 납치해갔다고 말했다.";
        talking[9] = "용사는 자신에게 걸린 저주를 풀기 위해 마을 사람들을 구하러 눈의 마녀에게 떠난다.";
        talking[10] = "튜토리얼로 이동합니다...";
        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 주인공
        showCnt[1] = 1;     // 적
        showCnt[2] = 2;     // 주인공
        showCnt[3] = 3;     // 적
        showCnt[4] = 4;     // 고양이
        showCnt[5] = 5;     // 적
        showCnt[6] = 6;     // 주인공
        showCnt[7] = 7;     // 적
        showCnt[8] = 8;     // 주인공
        showCnt[9] = 9;
        showCnt[10] = 10;  // 고양이
        // 순서로 이루어지는 대화
    }
}
