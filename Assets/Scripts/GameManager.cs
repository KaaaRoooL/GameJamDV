using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject prefab;
    private Vector3 spawnPoint;

    public List<GameObject> objects = new List<GameObject>();
   
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
        if(randomObject == 0){
            Instantiate(objects[0], PositionRandom(), Quaternion.identity);  
        } else if (randomObject == 1) {
            Instantiate(objects[1], PositionRandom(), Quaternion.identity); 
        } else if (randomObject == 2) {
            Instantiate(objects[2], PositionRandom(), Quaternion.identity); 
        } else if (randomObject == 3) {
            Instantiate(objects[3], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 4) {
            Instantiate(objects[4], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 5) {
            Instantiate(objects[5], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 6) {
            Instantiate(objects[6], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 7) {
            Instantiate(objects[7], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 8) {
            Instantiate(objects[8], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 9) {
            Instantiate(objects[9], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 10) {
            Instantiate(objects[10], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 11) {
            Instantiate(objects[11], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 12) {
            Instantiate(objects[12], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 13) {
            Instantiate(objects[13], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 14) {
            Instantiate(objects[14], PositionRandom(), Quaternion.identity);
        } else if (randomObject == 15) {
            Instantiate(objects[15], PositionRandom(), Quaternion.identity);
        } else {
            Instantiate(objects[16], PositionRandom(), Quaternion.identity);
        }                    
    }


    private Vector3 PositionRandom(){
        int randomPosition = Random.Range(0,5);
        if(randomPosition == 0){
            return spawnPoint = new Vector3(-7.9f, 5f, 0f);
        } else if (randomPosition == 1) {
            return spawnPoint = new Vector3(-4.7f, 5f, 0f);
        } else if (randomPosition == 2){
            return spawnPoint = new Vector3(0f, 5f, 0f);
        } else if (randomPosition == 3){
            return spawnPoint = new Vector3(4.7f, 5f, 0f);
        } else {
            return spawnPoint = new Vector3(-7.9f, 5f, 0f);
        }
    }
}
