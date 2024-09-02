using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3f;
    private float jumpPower = 5f;

    Rigidbody2D rigidbody;

    bool isJump = false;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);

            // transform.localScale = new Vector3(5.0f, transform.localScale.y, transform.localScale.z);
            // transform.eulerAngles = new Vector3(0f, 0f, 0f);
            GetComponent<SpriteRenderer>().flipX = false;

        } else if (Input.GetKey(KeyCode.LeftArrow)) {

            //transform.Translate(-speed * Time.deltaTime, 0f, 0f, Space.World);
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            
            // transform.localScale = new Vector3(-5.0f, transform.localScale.y, transform.localScale.z);
            // transform.eulerAngles = new Vector3(0f, 180f, 0f);
            GetComponent <SpriteRenderer>().flipX = true;
        } else
        {
            // 방향키 버튼에서 손을 뗀 경우 미끄러지지 않도록
            rigidbody.velocity = new Vector2(0f, rigidbody.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            isJump = true;
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }

        if(rigidbody.velocity.y == 0f )
        {
            isJump = false;
        }

    }
}
