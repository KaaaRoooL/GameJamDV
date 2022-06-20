using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodObject : MonoBehaviour
{
    public int points;

    public AudioClip eatSound;
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
        if(other.CompareTag("Player")){
            Score.instance.AddPoints(points);
            GameManager.instance.playAudioClip(eatSound);
            Destroy(gameObject);      
        }

    }
}
