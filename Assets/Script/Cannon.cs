using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRange = 5.5f;
    public float power = 500f;// ���� ���ư��� �Ŀ�

    public Transform spawnPoint;// ��Ÿ�� ��ġ
    public bool isRight;// ������ �������� �ٶ󺸴��� ����
    public bool isLeft;// ������ ������ �ٶ󺸴��� ����

    public GameObject red_Ball;
    public GameObject blue_Ball;
    public GameObject purple_Ball;
    public GameObject orange_Ball;
    public GameObject CannonBall;// ������ �߻�� ��

    public GameObject erb;// ���� ��
    public GameObject ebb;// �Ķ� ��
    public GameObject eob;// ��Ȳ ��
    public GameObject epb;// ���� ��

    List<GameObject> cannonsBall = new List<GameObject>();// �� Ű�� ������ ���� �ٸ� ���� ���� ���� ��

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
            isRight = false;// �ٶ󺸴� ������ �ٲ������ ���µ� �ٲ��ش�
            isLeft = true;
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
    void Shoot()
    {
        if (isRight)// �������� �ٶ� �� ���� ���������� ���
        {
            //GameObject newBullet = Instantiate(CannonBall);
            //newBullet.transform.position = new Vector3(0.0f, -3.2f, 0);
            GameObject newBullet = Instantiate(CannonBall, spawnPoint.position,
            Quaternion.identity) as GameObject;
            newBullet.transform.rotation = Quaternion.Euler(0, 0, 0);
            newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.right * power);
        }
        if (isLeft)// ������ �ٶ� �� ���� �������� ���
        {
            //GameObject newBullet = Instantiate(CannonBall);
            //newBullet.transform.position = new Vector3(0.0f, -3.2f, 0);
            GameObject newBullet = Instantiate(CannonBall, spawnPoint.position,
            Quaternion.identity) as GameObject;
            newBullet.transform.rotation = Quaternion.Euler(0, 180, 0);
            newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.left * power);
        }
    }// ���� �߻� �Լ�
    void TabBall()
    {
        if (Input.GetKeyDown(KeyCode.Tab))// �� ��ư�� ������ ��� ���� ���� �ٲ�� ��
        {
            Debug.Log(i);
            i++;
            if (i == 1)// �Ķ� ��
            {
                CannonBall = cannonsBall[1];
                erb.SetActive(false);// Ȯ�ο����� ���� ���� �� ��Ȱ��ȭ
                ebb.SetActive(true);// �Ķ� ������ Ȯ���� �� �ֵ��� Ȱ��ȭ
            }
            else if (i == 2)// ���� ��
            {
                CannonBall = cannonsBall[2];
                ebb.SetActive(false);
                epb.SetActive(true);
            }
            else if (i == 3)// ��Ȳ ��
            {
                CannonBall = cannonsBall[3];
                epb.SetActive(false);
                eob.SetActive(true);
            }
            else if (i == 4)// ���� ��
            {
                i = 0;
                CannonBall = cannonsBall[0];
                eob.SetActive(false);
                erb.SetActive(true);
            }
        }
    }// �� Ű�� ���� �� Ȱ��ȭ
}
