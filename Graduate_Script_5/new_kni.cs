using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_kni : MonoBehaviour
{
    public ParticleSystem summon;
    Animator animator;
    Rigidbody rigdbody;
    Vector3 movement;

    public float rotateSpeed = 200f;

    private bool Jump;

    public float speed = 5f;

    public int JumpPower;
    bool isSkill = false;
    float MoveHorizontal;
    float MoveVertical;
    bool skilluse = true;
    bool isAttacking = false;
    bool isJumping = false;
    public Transform parent;
    public Transform son;

    // Start is called before the first frame update
    void Awake()
    {
        summon.gameObject.SetActive(false);

        rigdbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        summon.transform.position = son.transform.position + new Vector3(0, 2, 0);
        son.transform.position = parent.transform.position;
        MoveHorizontal = Input.GetAxis("Horizontal");
        MoveVertical = Input.GetAxis("Vertical");

        Keyinput();
        AnimationUpdate();

        if (this.transform.position.y < -10)
        {
            this.transform.position = new Vector3(0, 0, -3);
        }
    }

    void FixedUpdate()
    {
        Run();

    }

    void AnimationUpdate()
    {
        if (MoveHorizontal == 0 && MoveVertical == 0)
        {
            animator.SetBool("isRunning", false);
        }
        else
        {
            animator.SetBool("isRunning", true);
        }

        if (isAttacking == true)
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
        if (isSkill == true)
        {

            animator.SetBool("isSkill", true);
        }
        else
        {

            animator.SetBool("isSkill", false);
        }
        if (isJumping == true)
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }


    }

    void Keyinput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("attacksound").GetComponent<AudioSource>().Play();
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            //knightmp Knimp = GameObject.Find("knightmp").GetComponent<knightmp>();
            if (skilluse)
            {
                knightmp.knight_mp--;
            }

            if (skilluse)
            {
                knighthp.knight_hp += 50;
                summon.gameObject.SetActive(true);
                summon.Play();
                GameObject.Find("potion_get_sound").GetComponent<AudioSource>().Play();
                isSkill = true;
            }

        }
        else
        {
            isSkill = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!Jump)
            {
                isJumping = true;
                Jump = true;
                rigdbody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            }
        }
        else
        {
            isJumping = false;
            //Jump = false;

            return;
        }
    }

    void Run()
    {
        movement.Set(MoveHorizontal, 0, MoveVertical);
        movement = (transform.right * MoveHorizontal * speed * Time.deltaTime
            + transform.forward * MoveVertical * speed * Time.deltaTime);
        rigdbody.MovePosition(transform.position + movement);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Jump = false;
        }

        if (collision.gameObject.CompareTag("Jumpgo"))
        {
            rigdbody.AddForce(Vector3.up * 9, ForceMode.Impulse);
        }
    }

}
