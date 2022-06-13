using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -7){
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Ghost.OnTriggerEnter");
        if(other.CompareTag("Player")){           
            Destroy(gameObject);      
        }
    }
}
