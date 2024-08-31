using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*
    Transform b;
    
    - MonoBehaviour�� ��ӹ��� ���
      GameObject, Transform�̶�� ������ �⺻������ �����Ѵ�.
    */

    // �ӵ�
    private float speed = 3;

    // Input Key

    /*
        Input.GetKeyDown : Ű�� �� �� ������ ���
        Input.GetKey() : Ű�� �����ִ� ����
        Input.GetKeyUp : Ű�� ������ ���

        Input.MouseButtonDown : ���콺�� �� �� ������ ���
        Input.MouseButton : ���콺�� �����ִ� ����
        Input.MouseButtonUp : ���콺�� ���ȴٰ� ������ ���
    */

    // Translate(x, y, z) : Object�� x, y, z ��ŭ �̵���Ų��.
    // Time.deltaTime : 1�ʸ� ���������� ���� ��
    // ��� ��ǻ�� �����ӿ��� ������ ���� ������ �����ϱ� ���ؼ� 


    void Start()
    {
        // b.position

        transform.position = new Vector3(-6, 0, 0);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            /*transform.position += new Vector3(speed, 0.0f, 0.0f);*/

            transform.Translate(speed * Time.deltaTime, 0, 0);

        } else if (Input.GetKey(KeyCode.LeftArrow)) {

            /*transform.position += new Vector3(-speed, 0.0f, 0.0f);*/

            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

    }
}
