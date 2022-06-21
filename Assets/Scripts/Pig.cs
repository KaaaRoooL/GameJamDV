using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    private float speed = 7.5f;
    float maxLimit = 8;
    protected Rigidbody2D rb;
    Animator animator;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {   
        if(GameManager.instance.IsGameOver()){
            return;
        }     
        if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x >= -maxLimit) {      
            animator.SetBool("Walk", true); 
            transform.localScale = new Vector3(1, 1, 1); 
            Vector3 newPosition = transform.position;         
            newPosition += Vector3.left * speed * Time.deltaTime; 
            transform.position = newPosition; 
                
        } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {   
            animator.SetBool("Walk", true);
            transform.localScale = new Vector3(-1, 1, 1);           
            Vector3 newPosition = transform.position;         
            newPosition += Vector3.right * speed * Time.deltaTime;
            
            if(newPosition.x >= maxLimit){
                newPosition.x = maxLimit;
            } 
            transform.position = newPosition;
        } else {
            animator.SetBool("Walk", false);
        }
    }   
}

