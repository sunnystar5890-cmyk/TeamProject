using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //(1)ī�޶� ��ο����ϴ�. ī�޶� �տ� ���������� ��ġ.
        //(2)�����ð� �ڿ� ������ϴ�.
        //(3)�÷��̾ � ��ġ���� �����մϴ�.

        //CinemachineConfiner2D -> BoundingShape A1 -> A1-1 (�ǹ����� ��輱 �ٲ۴�)
        //��ġ�� �̵�? ���� �̵����� ��� �÷��̾��� ���� ��ġ�� �ش� ��ġ�� �̵���Ų��.
        //player.transform.position = ����� ��ġ;
    }
}
