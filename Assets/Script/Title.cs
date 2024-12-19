using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject rightB;// 설명창 넘기기 버튼
    public GameObject leftB;// 설명창 뒤로 가기 버튼

    public GameObject explanation;// 설명창
    public GameObject oneText;// 첫번째 설명창
    public GameObject twoText;// 두번째 설명창

    public GameObject oubB;// 설명창 끄기 버튼

    public void LodeMain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Explanation()// 게임의 설명창 키는 함수
    {
        explanation.SetActive(true);// 설명창 키기
        oneText.SetActive(true);// 첫번째 설명 키기
        rightB.SetActive(true);// 넘기기 버튼 활성화
        oubB.SetActive(true);
    }

    public void OutE()// 설명창 끄기 함수
    {
        oubB.SetActive(false);
        explanation.SetActive(false);// 설명창 끄기
        oneText.SetActive(false);// 첫번째 설명 끄기
        rightB.SetActive(false);// 넘기기 버튼 비활성화
        twoText.SetActive(false);// 두번째 설명 끄기
        leftB.SetActive(false);// 돌아가기 버튼 비활성화
    }

    public void right()// 설명 넘기기 버튼
    {
        oneText.SetActive(false);// 첫번째 설명 끄기
        rightB.SetActive(false);// 넘기기 버튼 비활성화
        twoText.SetActive(true);// 두번째 설명 키기
        leftB.SetActive(true);// 돌아가기 버튼 활성화
    }

    public void left()
    {
        oneText.SetActive(true);// 첫번째 설명 키기
        rightB.SetActive(true);// 넘기기 버튼 활성화
        twoText.SetActive(false);// 두번째 설명 끄기
        leftB.SetActive(false);// 돌아가기 버튼 비활성화
    }

    public void Exit()// 게임 종료 함수
    {
        Application.Quit();
    }
}
