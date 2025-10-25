//using - : 네임스페이스 : 부산김민수 , 서울김민수
//public class 이름 : 클래스
//void Start( ){ }  : 함수, 메소드
//명령문statement : 코드 ; 으로 이루어져 있는 구성요소

using UnityEngine;  //다른 네임 스페이스에 만들어진 똑같은 이름의 클래스가 있다면 컴퓨터가 구별할수없다.
using System;

//

namespace UnityEngine
{
    public class MouseWorld : MonoBehaviour
    {
        private void Update() //프레임 마다 실행이 됩니다. 이미지가 그려지는 시간을 프레임. 계속해서 실행한다.
        {
                        //마우스의 위치를 world 세상으로 바꾸고 싶습니다.
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //각각이 컴퓨터에게 명령문
         Physics.Raycast(ray, out RaycastHit hit);                 // 명령문 : 광선으로부터 충돌한 지점을 가져온다. hit
         Debug.Log(hit.point);                                     // 명령문 : hit의 충돌 값을 vector값으로 출력한다.


        }


    }

}

