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
    public float speed;

    void Start()
    {
        // b.position

        transform.position = new Vector3(-6, 0, 0);
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0.0f, 0.0f);
    }
}
