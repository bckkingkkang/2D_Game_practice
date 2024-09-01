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
    private float speed = 3f;
    private float jumpPower = 5f;

    Rigidbody2D rigidbody;

    // Input Key

    /*
        Input.GetKeyDown : 키가 한 번 눌렸을 경우
        Input.GetKey() : 키가 눌려있는 동안
        Input.GetKeyUp : 키가 떼어진 경우

        Input.MouseButtonDown : 마우스가 한 번 눌렸을 경우
        Input.MouseButton : 마우스가 눌려있는 동안
        Input.MouseButtonUp : 마우스가 눌렸다가 떼어진 경우
    */

    // Translate(x, y, z) : Object를 x, y, z 만큼 이동시킨다.
    // Time.deltaTime : 1초를 프레임으로 나눈 값
    // 모든 컴퓨터 프레임에서 동일한 설정 값으로 동작하기 위해서 


    void Start()
    {
        // b.position

        // transform.position = new Vector3(-6, 0, 0);

        // GetComponent : 오브젝트가 가지고 있는 컴포넌트 중 하나를 가져옴
        rigidbody = GetComponent<Rigidbody2D>();

        // Rigidbody2D > info > velocity
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
            // transform.localScale = new Vector3(5.0f, transform.localScale.y, transform.localScale.z);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        } else if (Input.GetKey(KeyCode.LeftArrow)) {

            transform.Translate(-speed * Time.deltaTime, 0f, 0f, Space.World);
            // transform.localScale = new Vector3(-5.0f, transform.localScale.y, transform.localScale.z);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }

    }
}
