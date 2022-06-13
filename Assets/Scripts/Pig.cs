using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{


    private float speed = 8f;


    float maxLimit = 8;
    private float jumpForce = 6.5f;

    protected Collider2D collider;

    protected Rigidbody2D rb;
    Animator animator;

    
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    { 
      
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -maxLimit) {      
            animator.SetBool("Walk", true); 
            transform.localScale = new Vector3(1, 1, 1); 
            Vector3 newPosition = transform.position;         
            newPosition += Vector3.left * speed * Time.deltaTime; 
            transform.position = newPosition; 
                
        }
        if (Input.GetKey(KeyCode.RightArrow)) {   
            animator.SetBool("Walk", true);
            transform.localScale = new Vector3(-1, 1, 1);           
            Vector3 newPosition = transform.position;         
            newPosition += Vector3.right * speed * Time.deltaTime;
            

            if(newPosition.x >= maxLimit){
                newPosition.x = maxLimit;
            } 
            transform.position = newPosition;
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);  
        }
    }
}

