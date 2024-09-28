using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int HP = 5;

    private float speed = 3f;
    private float jumpPower = 5f;

    Rigidbody2D rigidbody;

    bool isJump = false;

    public GameObject Hit_Prefab;
    Animator anim;

    public Text HP_Text;
    public Slider HP_Slider;
    int MaxHp;
    

    public GameObject GameOverView;

    bool isOver = false;

    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        HP_Text.text = "HP : " + HP.ToString();
        MaxHp = HP;
        HP_Slider.value = (float)HP / (float)MaxHp;

    }

    void Update()
    {
        /*if (isOver)
        {
            // 캐릭터가 gameover 되었을 때 공중에 있는 경우 미끄러지지 않음
            //rigidbody.velocity = Vector2.zero;
            return;
        }*/
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;

            if (isJump == false)
            {
                AnimatorChange("isRUN");
                //.SetBool("isIDLE", false);
                //anim.SetBool("isRUN", true);
            }


        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;

            if (isJump == false)
            {
                AnimatorChange("isRUN");

                //anim.SetBool("isIDLE", false);
                //anim.SetBool("isRUN", true);
            }

        } else
        {
            rigidbody.velocity = new Vector2(0f, rigidbody.velocity.y);

            if (isJump == false)
            {
                AnimatorChange("isIDLE");

                //anim.SetBool("isIDLE", true);
                //anim.SetBool("isRUN", false);
            }

        }

        if (Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            isJump = true;

            AnimatorChange("isJUMP");
            //anim.SetTrigger("isJUMP");
            //anim.SetBool("isIDLE", false);
            //anim.SetBool("isRUN", false);
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);

            //GetComponent<SpriteRenderer>().sprite = JumpSprite;
        }

        if (rigidbody.velocity.y == 0f)
        {
            isJump = false;
        }

    }

    private void AnimatorChange(string temp)
    {
        anim.SetBool("isIDLE", false);
        anim.SetBool("isRUN", false);

        anim.SetBool(temp, true);

        if(temp == "isJUMP")
        {
            anim.SetTrigger("isJUMP");
            return;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Jump")
        {
            //Debug.Log(collision.gameObject.name + " : ENTER");
        }

        if(collision.gameObject.tag == "Obstacle")
        {
            //Debug.Log("방해물 닿음");
            HP--;
            GameObject go = Instantiate(Hit_Prefab, transform.position, Quaternion.identity);
            Destroy(go, 1.0f);
            anim.SetTrigger("isHit");

            // 화면 좌상단에 HP 표시
            HP_Text.text = "HP : " + HP.ToString();
            HP_Slider.value = (float)HP / (float)MaxHp;

            if (HP == 0)
            {
                isOver = true;
                GameOverView.SetActive(true);

                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jump")
        {
            //Debug.Log(collision.gameObject.name + " : STAY");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jump")
        {
            //Debug.Log(collision.gameObject.name + " : EXIT");
        }
    }
}
