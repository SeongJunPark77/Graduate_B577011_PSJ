using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wixz : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody rigdbody;
    Vector3 movement;

    // Start is called before the first frame update

    public float speed = 5f;
    public float rotateSpeed = 200f;


    public Transform parent;
    public Transform son;


    float MoveHorizontal;
    float MoveVertical;

    bool skilluse = true;
    bool isSkill = false;
    bool isDead = false;
    bool isAttacking = false;
    bool isDamaging = false;


    // Start is called before the first frame update
    void Awake()
    {


        rigdbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        son.transform.position = parent.transform.position;

        MoveVertical = Input.GetAxis("Vertical");
        MoveHorizontal = Input.GetAxis("Horizontal");

        //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();
        if (wizardmp.wizard_mp <= 0)
        {
            skilluse = false;
        }
        else if (wizardmp.wizard_mp > 0)
        {
            skilluse = true;
        }

        

        AnimationUpdate();
        Attack();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Run();
    }

    void Attack()
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

                //wizardmp Wzmp = GameObject.Find("wizardmp").GetComponent<wizardmp>();
                if (skilluse)
                {
                    wizardmp.wizard_mp--;
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

        if (isDamaging == true)
        {
            animator.SetBool("isDamaging", true);
        }
        else
        {
            animator.SetBool("isDamaging", false);
        }

        if (isDead == true)
        {
            animator.SetBool("isDead", true);
        }
        else
        {
            animator.SetBool("isDead", false);
        }

    }
    void Run()
    {
        movement.Set(MoveHorizontal, 0, MoveVertical);
        movement = (transform.right * MoveHorizontal * speed * Time.deltaTime
            + transform.forward * MoveVertical * speed * Time.deltaTime);
        rigdbody.MovePosition(transform.position + movement);
    }
}
