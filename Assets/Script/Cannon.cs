using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRange = 5.5f;
    public float power = 500f;// 공이 날아가는 파워

    public Transform spawnPoint;// 나타날 위치
    public bool isRight;// 대포가 오른쪽을 바라보는지 여부
    public bool isLeft;// 대포가 왼쪽을 바라보는지 여부

    public GameObject red_Ball;
    public GameObject blue_Ball;
    public GameObject purple_Ball;
    public GameObject orange_Ball;
    public GameObject CannonBall;// 실제로 발사될 공

    public GameObject erb;// 빨간 공
    public GameObject ebb;// 파란 공
    public GameObject eob;// 주황 공
    public GameObject epb;// 보라 공

    List<GameObject> cannonsBall = new List<GameObject>();// 탭 키를 누름에 따라 다른 색의 공이 나갈 것

    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        isRight = false;
        isLeft = true;
        cannonsBall.Add(red_Ball);
        cannonsBall.Add(blue_Ball);
        cannonsBall.Add(purple_Ball);
        cannonsBall.Add(orange_Ball);
        Debug.Log(i);
        CannonBall = cannonsBall[0];
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxisRaw(
        //    "Horizontal") * speed * Time.deltaTime, 0, 0);
        //transform.position = new Vector2(Mathf.Clamp(
        //    transform.position.x, -moveableRange, moveableRange),
        //    transform.position.y);
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TabBall();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isRight = true;
            isLeft = false;
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isRight = false;// 바라보는 방향이 바뀌었으니 상태도 바꿔준다
            isLeft = true;
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
    void Shoot()
    {
        if (isRight)// 오른쪽을 바라볼 때 공을 오른쪽으로 쏜다
        {
            //GameObject newBullet = Instantiate(CannonBall);
            //newBullet.transform.position = new Vector3(0.0f, -3.2f, 0);
            GameObject newBullet = Instantiate(CannonBall, spawnPoint.position,
            Quaternion.identity) as GameObject;
            newBullet.transform.rotation = Quaternion.Euler(0, 0, 0);
            newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.right * power);
        }
        if (isLeft)// 왼쪽을 바라볼 때 공을 왼쪽으로 쏜다
        {
            //GameObject newBullet = Instantiate(CannonBall);
            //newBullet.transform.position = new Vector3(0.0f, -3.2f, 0);
            GameObject newBullet = Instantiate(CannonBall, spawnPoint.position,
            Quaternion.identity) as GameObject;
            newBullet.transform.rotation = Quaternion.Euler(0, 180, 0);
            newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.left * power);
        }
    }// 구슬 발사 함수
    void TabBall()
    {
        if (Input.GetKeyDown(KeyCode.Tab))// 탭 버튼을 누르면 쏘는 공의 색이 바뀌게 함
        {
            Debug.Log(i);
            i++;
            if (i == 1)// 파란 공
            {
                CannonBall = cannonsBall[1];
                erb.SetActive(false);// 확인용으로 만든 빨간 공 비활성화
                ebb.SetActive(true);// 파란 공으로 확인할 수 있도록 활성화
            }
            else if (i == 2)// 보라 공
            {
                CannonBall = cannonsBall[2];
                ebb.SetActive(false);
                epb.SetActive(true);
            }
            else if (i == 3)// 주황 공
            {
                CannonBall = cannonsBall[3];
                epb.SetActive(false);
                eob.SetActive(true);
            }
            else if (i == 4)// 빨간 공
            {
                i = 0;
                CannonBall = cannonsBall[0];
                eob.SetActive(false);
                erb.SetActive(true);
            }
        }
    }// 탭 키를 누를 시 활성화
}
