using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)// 같은 색의 공과 충돌하면 삭제됨, 숫자 세는것도
    {
        if (this.gameObject.tag == "Red")// 구슬이 붉은색의 태그일 때
        {
            if (coll.gameObject.tag == "Red")// 다른 붉은색 태그를 가진 구슬과 충돌하면
            {
                Destroy(coll.gameObject);//적을 파괴
                Destroy(this.gameObject);//자신을 파괴
                GameManager.v_int += 1;
            }
            else// 다른 태그와 충돌할 때
            {
                if (coll.gameObject.tag != "Cannon")// 대포가 아닐 때
                {
                    Destroy(coll.gameObject);//적을 파괴
                    Destroy(this.gameObject);//자신을 파괴
                    GameManager.o_int += 1;
                }
            }
        }
        if (this.gameObject.tag == "Blue")
        {
            if (coll.gameObject.tag == "Blue")
            {
                Destroy(coll.gameObject);//적을 파괴
                Destroy(this.gameObject);//자신을 파괴
                GameManager.v_int += 1;
            }
            else// 다른 태그와 충돌할 때
            {
                if (coll.gameObject.tag != "Cannon")// 대포가 아닐 때
                {
                    Destroy(coll.gameObject);//적을 파괴
                    Destroy(this.gameObject);//자신을 파괴
                    GameManager.o_int += 1;
                }
            }
        }
        if (this.gameObject.tag == "Orange")
        {
            if (coll.gameObject.tag == "Orange")
            {
                Destroy(coll.gameObject);//적을 파괴
                Destroy(this.gameObject);//자신을 파괴
                GameManager.v_int += 1;
            }
            else// 다른 태그와 충돌할 때
            {
                if (coll.gameObject.tag != "Cannon")// 대포가 아닐 때
                {
                    Destroy(coll.gameObject);//적을 파괴
                    Destroy(this.gameObject);//자신을 파괴
                    GameManager.o_int += 1;
                }
            }
        }
        if (this.gameObject.tag == "Purple")
        {
            if (coll.gameObject.tag == "Purple")
            {
                Destroy(coll.gameObject);//적을 파괴
                Destroy(this.gameObject);//자신을 파괴
                GameManager.v_int += 1;
            }
            else// 다른 태그와 충돌할 때
            {
                if (coll.gameObject.tag != "Cannon")// 대포가 아닐 때
                {
                    Destroy(coll.gameObject);//적을 파괴
                    Destroy(this.gameObject);//자신을 파괴
                    GameManager.o_int += 1;
                }
            }
        }
        if (coll.gameObject.tag == "Cannon")
        {
            Destroy(this.gameObject);//대포에 부딪히면 구슬 자신을 사라지게 함
            GameManager.f_int += 1;
        }
    }
}
