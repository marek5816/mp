using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagelMover : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction = Vector3.right;
    public float distanceToTravel = 50f;
    private Vector3 startPosition;
    
    private Animator animator;
    private bool isDying = false;
    private bool dyingSwitch = true;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDying == true) {
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Death") ||
                animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                Destroy(gameObject);
            }

            /*if (dyingSwitch) {
                dyingSwitch = false;
                animator.Play("Death");
            }*/
        } else {
            dieDespawn();
            transform.Translate(direction * speed * Time.deltaTime);

            if (Vector3.Distance(startPosition, transform.position) >= distanceToTravel)
            {   
                Destroy(gameObject);

                
    /*
                animator.Play("Eagle_Die");
                isDying = true;
                if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Eagle_Die") ||
                    animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
                {
                    //Destroy(gameObject);
                }
                //Destroy(gameObject);
    */
            }
        }

    }

    public void dieDespawn() {
        isDying = true;
        animator.Play("Death");
    }
}
