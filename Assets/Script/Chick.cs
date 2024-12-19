using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public GameObject[] ball;// ������ ���� ������ ����Ʈ

    public float currLTime;// �ð� ��� ����
    public float currRTime = 1f;

    // Update is called once per frame
    void Update()
    {
        currLTime += Time.deltaTime;// �ð��� �帣�� �� ��
        currRTime += Time.deltaTime;

        if (currLTime >= 3)// 2�ʸ��� ������ ��
        {
            LAttack();
        }
        if (currRTime >= 3)
            RAttack();
    }

    void LAttack()// �����ʿ��� ���� ������ ���ư��� �Լ�
    {
        int rs = Random.RandomRange(0, ball.Length);// ������ ���� ���� �̵���
        GameObject mon = Instantiate(ball[rs]);// mon ������ ������ ���� �ȴ�
        mon.transform.position = new Vector3(8.5f, -3.0f, 0);// �� ��ġ�� ���� ������
        mon.transform.rotation = Quaternion.Euler(0, 180, 0);
        mon.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 300f);// ���� 500f�� ������ ���������� ���ư�

        currLTime = 0;// ������ �ð��� �ٽ� �ʱ�ȭ �����ش�
    }
    void RAttack()// ���ʿ��� ���� ������ ���ư��� �Լ�
    {
        int rs = Random.RandomRange(0, ball.Length);// ������ ���� ���� �̵���
        GameObject mon = Instantiate(ball[rs]);// mon ������ ������ ���� �ȴ�
        mon.transform.position = new Vector3(-8.5f, -3.0f, 0);// �� ��ġ�� ���� ������
        mon.transform.rotation = Quaternion.Euler(0, 0, 0);
        mon.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 300f);// ���� 500f�� ������ ���������� ���ư�

        currRTime = 0;// ������ �ð��� �ٽ� �ʱ�ȭ �����ش�
    }
    
}
