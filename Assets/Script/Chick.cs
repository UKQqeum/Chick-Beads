using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public GameObject[] ball;// 적으로 나올 공들의 리스트

    public float currLTime;// 시간 담당 변수
    public float currRTime = 1f;

    // Update is called once per frame
    void Update()
    {
        currLTime += Time.deltaTime;// 시간이 흐르게 해 줌
        currRTime += Time.deltaTime;

        if (currLTime >= 3)// 2초마다 생성할 것
        {
            LAttack();
        }
        if (currRTime >= 3)
            RAttack();
    }

    void LAttack()// 오른쪽에서 공의 생성과 날아가는 함수
    {
        int rs = Random.RandomRange(0, ball.Length);// 랜덤한 색의 공을 뽑도록
        GameObject mon = Instantiate(ball[rs]);// mon 변수가 랜덤한 공이 된다
        mon.transform.position = new Vector3(8.5f, -3.0f, 0);// 이 위치에 공이 생성됨
        mon.transform.rotation = Quaternion.Euler(0, 180, 0);
        mon.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 300f);// 공이 500f의 힘으로 오른쪽으로 날아감

        currLTime = 0;// 끝나고 시간을 다시 초기화 시켜준다
    }
    void RAttack()// 왼쪽에서 공의 생성과 날아가는 함수
    {
        int rs = Random.RandomRange(0, ball.Length);// 랜덤한 색의 공을 뽑도록
        GameObject mon = Instantiate(ball[rs]);// mon 변수가 랜덤한 공이 된다
        mon.transform.position = new Vector3(-8.5f, -3.0f, 0);// 이 위치에 공이 생성됨
        mon.transform.rotation = Quaternion.Euler(0, 0, 0);
        mon.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 300f);// 공이 500f의 힘으로 오른쪽으로 날아감

        currRTime = 0;// 끝나고 시간을 다시 초기화 시켜준다
    }
    
}
