using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    public SimpleBoolData groundCheck;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = groundCheck.value;
        if(!grounded)
        {
            animator.SetTrigger("Fall");
        }
        if(grounded)
        {
            animator.SetTrigger("NotGrounded");
            HandleAnimations();
        }
        
    }

    private void HandleAnimations()
    {

        if (Input.GetAxis("Horizontal") != 0)
        {
            {
                animator.SetTrigger("Run");
            }
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }

    public void Death()
    {
        animator.SetTrigger("Death");
        Destroy(gameObject, 0.6f);
    }
}
