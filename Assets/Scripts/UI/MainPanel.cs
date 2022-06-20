using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
   private AudioSource audioSource;
   public AudioClip menuSound;

   void Start(){
      audioSource = GetComponent<AudioSource>();
      playAudioClip(menuSound);
   }
   public void ButtonPlayOnClick() {
       SceneManager.LoadScene("PigScene");
   }

   public void ButtonExitOnClick() {
   #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
   #else
         Application.Quit();
   #endif       
   }


    public void playAudioClip(AudioClip clip){
        audioSource.PlayOneShot(clip);
    }
}
