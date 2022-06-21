using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public void OnEnable() {
        Time.timeScale = 0;
    }
     

    public void ButtonResetOnClick() {
        SceneManager.LoadScene("PigScene");
        Time.timeScale = 1;
    }

    
    public void ButtonMainmenuOnClick() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

}
