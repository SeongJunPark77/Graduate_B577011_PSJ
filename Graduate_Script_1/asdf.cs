using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asdf : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody rigdbody;
    Vector3 movement;
    Vector3 movement2;

    public float rotateSpeed = 200f;

    private bool Jump;

    public float speed = 5f;

    public int JumpPower;

    float MoveHorizontal;
    float MoveVertical;

    bool isAttacking = false;
    bool isJumping = false;
    bool isSkill = false;
    public Transform parent;
    public Transform son;
    bool skilluse = true;


    // Start is called before the first frame update
    void Awake()
    {
        rigdbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        son.transform.position = parent.transform.position;

        MoveHorizontal = Input.GetAxis("Horizontal");
        MoveVertical = Input.GetAxis("Vertical");

        if (archermp.archer_mp <= 0)
        {
            skilluse = false;
        }
        else if (archermp.archer_mp > 0)
        {
            skilluse = true;
        }



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
            //archermp Armp = GameObject.Find("archermp").GetComponent<archermp>();
            if (skilluse)
            {
                archermp.archer_mp--;
            }


            if (skilluse)
            {
                GameObject.Find("attacksound").GetComponent<AudioSource>().Play();
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
    void Run()
    {
        movement.Set(MoveHorizontal, 0, MoveVertical);
        movement = (transform.right * MoveHorizontal * speed * Time.deltaTime
            + transform.forward * MoveVertical * speed * Time.deltaTime);
        rigdbody.MovePosition(transform.position + movement);
    }

    //void Turn()
    //{
    //    //if (MoveHorizontal == 0 && MoveVertical == 0)
    //    //    return;

    //    //movement2.Set(MoveHorizontal, 0, MoveVertical);
    //    //movement2 = transform.localEulerAngles;

    //    //Quaternion newRotation = Quaternion.LookRotation(movement2);
    //    ////rigdbody.MoveRotation(newRotation);
    //    //rigdbody.rotation = Quaternion.Slerp(rigdbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        this.transform.localEulerAngles = new Vector3(0, 0, 0);
    //    }

    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        this.transform.localEulerAngles = new Vector3(0, -90, 0);


    //    }

    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        this.transform.localEulerAngles = new Vector3(0, 180, 0);
    //    }

    //    if (Input.GetKeyDown(KeyCode.D))
    //    {
    //        this.transform.localEulerAngles = new Vector3(0, 90, 0);
    //    }
    //}

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

