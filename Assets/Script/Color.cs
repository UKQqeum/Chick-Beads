using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)// ���� ���� ���� �浹�ϸ� ������, ���� ���°͵�
    {
        if (this.gameObject.tag == "Red")// ������ �������� �±��� ��
        {
            if (coll.gameObject.tag == "Red")// �ٸ� ������ �±׸� ���� ������ �浹�ϸ�
            {
                Destroy(coll.gameObject);//���� �ı�
                Destroy(this.gameObject);//�ڽ��� �ı�
                GameManager.v_int += 1;
            }
            else// �ٸ� �±׿� �浹�� ��
            {
                if (coll.gameObject.tag != "Cannon")// ������ �ƴ� ��
                {
                    Destroy(coll.gameObject);//���� �ı�
                    Destroy(this.gameObject);//�ڽ��� �ı�
                    GameManager.o_int += 1;
                }
            }
        }
        if (this.gameObject.tag == "Blue")
        {
            if (coll.gameObject.tag == "Blue")
            {
                Destroy(coll.gameObject);//���� �ı�
                Destroy(this.gameObject);//�ڽ��� �ı�
                GameManager.v_int += 1;
            }
            else// �ٸ� �±׿� �浹�� ��
            {
                if (coll.gameObject.tag != "Cannon")// ������ �ƴ� ��
                {
                    Destroy(coll.gameObject);//���� �ı�
                    Destroy(this.gameObject);//�ڽ��� �ı�
                    GameManager.o_int += 1;
                }
            }
        }
        if (this.gameObject.tag == "Orange")
        {
            if (coll.gameObject.tag == "Orange")
            {
                Destroy(coll.gameObject);//���� �ı�
                Destroy(this.gameObject);//�ڽ��� �ı�
                GameManager.v_int += 1;
            }
            else// �ٸ� �±׿� �浹�� ��
            {
                if (coll.gameObject.tag != "Cannon")// ������ �ƴ� ��
                {
                    Destroy(coll.gameObject);//���� �ı�
                    Destroy(this.gameObject);//�ڽ��� �ı�
                    GameManager.o_int += 1;
                }
            }
        }
        if (this.gameObject.tag == "Purple")
        {
            if (coll.gameObject.tag == "Purple")
            {
                Destroy(coll.gameObject);//���� �ı�
                Destroy(this.gameObject);//�ڽ��� �ı�
                GameManager.v_int += 1;
            }
            else// �ٸ� �±׿� �浹�� ��
            {
                if (coll.gameObject.tag != "Cannon")// ������ �ƴ� ��
                {
                    Destroy(coll.gameObject);//���� �ı�
                    Destroy(this.gameObject);//�ڽ��� �ı�
                    GameManager.o_int += 1;
                }
            }
        }
        if (coll.gameObject.tag == "Cannon")
        {
            Destroy(this.gameObject);//������ �ε����� ���� �ڽ��� ������� ��
            GameManager.f_int += 1;
        }
    }
}
