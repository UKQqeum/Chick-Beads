using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject rightB;// ����â �ѱ�� ��ư
    public GameObject leftB;// ����â �ڷ� ���� ��ư

    public GameObject explanation;// ����â
    public GameObject oneText;// ù��° ����â
    public GameObject twoText;// �ι�° ����â

    public GameObject oubB;// ����â ���� ��ư

    public void LodeMain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Explanation()// ������ ����â Ű�� �Լ�
    {
        explanation.SetActive(true);// ����â Ű��
        oneText.SetActive(true);// ù��° ���� Ű��
        rightB.SetActive(true);// �ѱ�� ��ư Ȱ��ȭ
        oubB.SetActive(true);
    }

    public void OutE()// ����â ���� �Լ�
    {
        oubB.SetActive(false);
        explanation.SetActive(false);// ����â ����
        oneText.SetActive(false);// ù��° ���� ����
        rightB.SetActive(false);// �ѱ�� ��ư ��Ȱ��ȭ
        twoText.SetActive(false);// �ι�° ���� ����
        leftB.SetActive(false);// ���ư��� ��ư ��Ȱ��ȭ
    }

    public void right()// ���� �ѱ�� ��ư
    {
        oneText.SetActive(false);// ù��° ���� ����
        rightB.SetActive(false);// �ѱ�� ��ư ��Ȱ��ȭ
        twoText.SetActive(true);// �ι�° ���� Ű��
        leftB.SetActive(true);// ���ư��� ��ư Ȱ��ȭ
    }

    public void left()
    {
        oneText.SetActive(true);// ù��° ���� Ű��
        rightB.SetActive(true);// �ѱ�� ��ư Ȱ��ȭ
        twoText.SetActive(false);// �ι�° ���� ����
        leftB.SetActive(false);// ���ư��� ��ư ��Ȱ��ȭ
    }

    public void Exit()// ���� ���� �Լ�
    {
        Application.Quit();
    }
}
