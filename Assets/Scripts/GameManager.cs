using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 spawnPoint;
    public List<GameObject> objects = new List<GameObject>();
    public static GameManager instance;
    private AudioSource audioSource;
    public AudioClip sceneSound;
    private bool gameOver;
    public GameObject pausePanel;
    public GameObject gameOverPanel;

    void Awake() {
        instance = this;
    }
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playAudioClip(sceneSound);
        gameOver = false;
    }
  
    void Update()
    {
        if(GameManager.instance.IsGameOver()){
            return;
        }
        if(Random.value <= Time.deltaTime*2){
            Spawn();        
        }
        if(Input.GetKey(KeyCode.P) || Input.GetKey(KeyCode.Escape)) {      
            pausePanel.SetActive(true);
            Time.timeScale = 0;                
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

    public void playAudioClip(AudioClip clip){
        audioSource.PlayOneShot(clip);
    }

    public void GameOver(){      
        gameOver = true;
        gameOverPanel.SetActive(true);  
    }

    public bool IsGameOver(){
        return gameOver;
    }



    
 
}
