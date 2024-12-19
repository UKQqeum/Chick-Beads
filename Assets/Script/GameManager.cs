using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BackP;// 백 판넬
    public GameObject StopB;// 멈추기 버튼
    public GameObject StartB;// 실행 버튼

    public static int v_int = 0;// 성공적으로 공을 없앤 횟수
    public static int o_int = 0;// 다른 색으로 공을 없앤 횟수
    public static int f_int = 0;// 공을 맞추지 못 한 횟수

    public Text victory;// 성공적으로 공을 맞춘 텍스트
    public Text other;// 다른 색의 공으로 맞춘 텍스트
    public Text fail;// 공 맞추기 실패한 텍스트

    
    // Start is called before the first frame update
    void Start()
    {
        BackP.SetActive(false);

        victory = GameObject.Find("victory_Text").GetComponent<Text>();
        other = GameObject.Find("other_Text").GetComponent<Text>();
        fail = GameObject.Find("fail_Text").GetComponent<Text>();
    }

    public void TimeStop()// 일시정지 버튼
    {
        Time.timeScale = 0;
        BackP.SetActive(true);// 백 판넬 활성화하기
        StopB.SetActive(false);// 스탑 버튼 비활성화하기
        victory.text = ("성공적으로 공을 맞춘 횟수 : " + v_int.ToString());
        other.text = ("잘못된 공을 맞춘 횟수 : " + o_int.ToString());
        fail.text = ("공을 없애지 못 한 횟수 : " + f_int.ToString());
        return;
    }
    public void ReStart()// 일시정지를 비활성화하는 버튼
    {
        Time.timeScale = 1;
        BackP.SetActive(false);// 백 판넬 비활성화
        StopB.SetActive(true);// 스탑 버튼 활성화
        return;
    }

    public void Exit()// 게임 종료 함수
    {
        Application.Quit();
    }
}
