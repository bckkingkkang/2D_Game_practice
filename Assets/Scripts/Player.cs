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
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);

            GetComponent<SpriteRenderer>().flipX = false;

        } else if (Input.GetKey(KeyCode.LeftArrow)) {

            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            
            GetComponent <SpriteRenderer>().flipX = true;
        } else
        {
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Off")
        {
            Debug.Log(collision.gameObject.name + " : ENTER");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Off")
        {
            Debug.Log(collision.gameObject.name + " : STAY");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Off")
        {
            Debug.Log(collision.gameObject.name + " : EXIT");
        }
    }
}
