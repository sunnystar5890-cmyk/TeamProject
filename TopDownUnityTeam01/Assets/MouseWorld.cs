//using - : ���ӽ����̽� : �λ��μ� , �����μ�
//public class �̸� : Ŭ����
//void Start( ){ }  : �Լ�, �޼ҵ�
//��ɹ�statement : �ڵ� ; ���� �̷���� �ִ� �������

using UnityEngine;  //�ٸ� ���� �����̽��� ������� �Ȱ��� �̸��� Ŭ������ �ִٸ� ��ǻ�Ͱ� �����Ҽ�����.
using System;

//

namespace UnityEngine
{
    public class MouseWorld : MonoBehaviour
    {
        private void Update() //������ ���� ������ �˴ϴ�. �̹����� �׷����� �ð��� ������. ����ؼ� �����Ѵ�.
        {
                        //���콺�� ��ġ�� world �������� �ٲٰ� �ͽ��ϴ�.
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //������ ��ǻ�Ϳ��� ��ɹ�
         Physics.Raycast(ray, out RaycastHit hit);                 // ��ɹ� : �������κ��� �浹�� ������ �����´�. hit
         Debug.Log(hit.point);                                     // ��ɹ� : hit�� �浹 ���� vector������ ����Ѵ�.


        }


    }

}

