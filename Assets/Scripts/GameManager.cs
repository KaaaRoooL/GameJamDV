using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject prefab;
    private Vector3 spawnPoint;

    public List<GameObject> objects = new List<GameObject>();

    public static GameManager instance;

    
   
    void Start()
    {
          
    }

    
    void Update()
    {
        if(Random.value <= 0.001f){
            Spawn();        
        }
    }

   private void Spawn() {
        int randomObject = Random.Range(0,16);
        Instantiate(objects[randomObject], PositionRandom(), Quaternion.identity);                    
    }


    private Vector3 PositionRandom(){
        int randomPosition = Random.Range(0,5);
        if(randomPosition == 0){
            return spawnPoint = new Vector3(-7.9f, 5f, 0f);
        } else if (randomPosition == 1) {
            return spawnPoint = new Vector3(-4.7f, 5f, 0f);
        } else if (randomPosition == 2){
            return spawnPoint = new Vector3(0f, 5f, 0f);
        } else {
            return spawnPoint = new Vector3(4.7f, 5f, 0f);
        } 
    }

    public void ClearList(){
        for(int i = 0 ; i < objects.Count; i++){
            objects.Remove(objects[i]);
        }
        
    }


    
}
