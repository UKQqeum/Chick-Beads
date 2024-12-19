using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BackP;// �� �ǳ�
    public GameObject StopB;// ���߱� ��ư
    public GameObject StartB;// ���� ��ư

    public static int v_int = 0;// ���������� ���� ���� Ƚ��
    public static int o_int = 0;// �ٸ� ������ ���� ���� Ƚ��
    public static int f_int = 0;// ���� ������ �� �� Ƚ��

    public Text victory;// ���������� ���� ���� �ؽ�Ʈ
    public Text other;// �ٸ� ���� ������ ���� �ؽ�Ʈ
    public Text fail;// �� ���߱� ������ �ؽ�Ʈ

    
    // Start is called before the first frame update
    void Start()
    {
        BackP.SetActive(false);

        victory = GameObject.Find("victory_Text").GetComponent<Text>();
        other = GameObject.Find("other_Text").GetComponent<Text>();
        fail = GameObject.Find("fail_Text").GetComponent<Text>();
    }

    public void TimeStop()// �Ͻ����� ��ư
    {
        Time.timeScale = 0;
        BackP.SetActive(true);// �� �ǳ� Ȱ��ȭ�ϱ�
        StopB.SetActive(false);// ��ž ��ư ��Ȱ��ȭ�ϱ�
        victory.text = ("���������� ���� ���� Ƚ�� : " + v_int.ToString());
        other.text = ("�߸��� ���� ���� Ƚ�� : " + o_int.ToString());
        fail.text = ("���� ������ �� �� Ƚ�� : " + f_int.ToString());
        return;
    }
    public void ReStart()// �Ͻ������� ��Ȱ��ȭ�ϴ� ��ư
    {
        Time.timeScale = 1;
        BackP.SetActive(false);// �� �ǳ� ��Ȱ��ȭ
        StopB.SetActive(true);// ��ž ��ư Ȱ��ȭ
        return;
    }

    public void Exit()// ���� ���� �Լ�
    {
        Application.Quit();
    }
}
