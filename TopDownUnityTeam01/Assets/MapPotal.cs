using Unity.Cinemachine;
using UnityEngine;

public class MapPotal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //1)Cinemachine Confiner2D�� BoundingShape A�ȿ� BoxCollider2r2D�� �ٲ�� �Ѵ�.   

    //2)�÷��̾��� ĳ���͸� ���ϴ� �������� �̵��ؾ� �Ѵ�.

    //3)Entry�� �浹 ������ ����� ��

    public Transform movePosition;
    public Collider2D mapBoundary;    //MapPortal�÷��̾ ������� �̵��ؾ� �� ī�޶� ��踦 �־��ּ���
    public CinemachineConfiner2D Confiner;  // CinemachineConfiner2D�����͸� ������ �� �ִ� ����, �����Ͱ� ������� �ʴ�.
    public Animator SceneTransitionAnimator; //��� ������� �� ��ȭ ���ִϸ����͸� ���⿡ �����ϼ���


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //Tag�� �÷��̾��� �༮�� ���� ������ �ϴ�
        {
            Confiner.BoundingShape2D = mapBoundary;

            //collision.transform.position = �̵��ϰ� ���� ��ġ�� �̵��϶�
            collision.transform.position = movePosition.position;

            SceneTransitionAnimator.SetTrigger("Show");

        }
       
    }
}
