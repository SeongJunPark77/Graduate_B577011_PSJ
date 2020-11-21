using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ending_2 : MonoBehaviour
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

        charactors = new Image[8];  // 이미지 호출할 배열을 만듭니다.  // 적
        charactors[0] = GameObject.Find("Canvas").transform.Find("monster1").GetComponent<Image>();
        charactors[1] = GameObject.Find("Canvas").transform.Find("wizard1").GetComponent<Image>();
        charactors[2] = GameObject.Find("Canvas").transform.Find("knight1").GetComponent<Image>();
        charactors[3] = GameObject.Find("Canvas").transform.Find("warlord1").GetComponent<Image>();
        charactors[4] = GameObject.Find("Canvas").transform.Find("archer1").GetComponent<Image>();
        charactors[5] = GameObject.Find("Canvas").transform.Find("allcha").GetComponent<Image>();
        charactors[6] = GameObject.Find("Canvas").transform.Find("cut1").GetComponent<Image>();
        charactors[7] = GameObject.Find("Canvas").transform.Find("nothing1").GetComponent<Image>();
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
        for (int i = 0; i < 8; i++)      // 등장인물의 수만큼을 써줍니다. 여기는 3명이 등장합니다.
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
        talking[1] = "'죽어라'";
        talking[2] = "'겨우..끝났어'";
        talking[3] = "'저기 마을 사람들이 있어요'";
        talking[4] = "'결국 이렇게 된건가.. 죽이십시오'";
        talking[5] = "'무슨 소리죠? 저희는 여러분을 구하러 왔습니다'";
        talking[6] = "'그게 대체 무슨... 당신은 마왕의 부하이지 않습니까'";

        talking[7] = "'마을 입구에 있던 영감님이 이쪽에 눈의 마녀가 마을 사람들을 납치하고 있다고..'";
        talking[8] = "'네? 저희는 당신이 방금 죽인 그녀덕에 마왕의 부하들로부터 여기에 도망쳐 온겁니다'";
        talking[9] = "'그게 대체...? 마녀의 저주로 눈덮힌 주술의 마을이 아닌가요?'";
        talking[10] = "'이곳은 원래 눈이 항상 내리는 마을입니다.. 또한 주술의 마을은 맞지만 그녀가 저희 마을의 마지막 주술사였지요'";
        talking[11] = "'이게 대체 무슨 일이지...그럼 마을에 있던 그 영감은 누굽니까?'";
        talking[12] = "'마을 사람들은 한명도 빠짐없이 대피를 했습니다. 마을에 남은 사람은 없어요'";
        talking[13] = "'그렇다면 지금까지 신경 안쓰고 넘겨왔던 문서들이...?'";
        talking[14] = "'속은거야, 그 영감, 아니 마왕의 부하한테'";
        talking[15] = "'그렇다면 우리 저주는...?'";
        talking[16] = "'보아하니 당신에게 걸린 저주는 상당히 강력한 저주인데 그녀가 죽은 이상 저주를 풀 사람은 이 세계에 없습니다'";
        talking[17] = "'이럴 순 없어 우린 지금까지 무슨...!!'";
        talking[18] = "-모든걸 깨달은 용사는 정신이 나간채 마을을 떠났고 이후 용사에 대한 소문은 더이상 들리지 않았다-";
        talking[19] = "-SAD ENDING-";
        talking[20] = "";
        ////////////////////////////////////////

        //// 캐릭터의 등장 순서를 설정합니다.
        showCnt[0] = 0;     // 적
        showCnt[1] = 3;
        showCnt[2] = 4;
        showCnt[3] = 1;
        showCnt[4] = 6;
        showCnt[5] = 4;
        showCnt[6] = 6;
        showCnt[7] = 2;     // 적
        showCnt[8] = 6;
        showCnt[9] = 1;
        showCnt[10] = 6;
        showCnt[11] = 2;
        showCnt[12] = 6;
        showCnt[13] = 4;
        showCnt[14] = 2;     // 적
        showCnt[15] = 3;
        showCnt[16] = 6;
        showCnt[17] = 2;
        showCnt[18] = 7;
        showCnt[19] = 7;
        showCnt[20] = 7;

        // 순서로 이루어지는 대화
    }
}
