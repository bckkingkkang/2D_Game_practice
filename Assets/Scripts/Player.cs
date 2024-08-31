using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*
    Transform b;
    
    - MonoBehaviour를 상속받은 경우
      GameObject, Transform이라는 변수를 기본적으로 내재한다.
    */

    // 속도
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
