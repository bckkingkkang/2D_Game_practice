using UnityEngine;

public class Player : MonoBehaviour
{
    public int HP = 5;

    private float speed = 3f;
    private float jumpPower = 5f;

    Rigidbody2D rigidbody;

    bool isJump = false;

    public GameObject Hit_Prefab;
    Animator anim;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        if(collision.gameObject.name == "Jump")
        {
            Debug.Log(collision.gameObject.name + " : ENTER");
        }

        if(collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("방해물 닿음");
            HP--;
            GameObject go = Instantiate(Hit_Prefab, transform.position, Quaternion.identity);
            Destroy(go, 1.0f);
            anim.SetTrigger("isHit");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jump")
        {
            Debug.Log(collision.gameObject.name + " : STAY");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jump")
        {
            Debug.Log(collision.gameObject.name + " : EXIT");
        }
    }
}
