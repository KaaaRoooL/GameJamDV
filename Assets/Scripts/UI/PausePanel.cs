using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnEnable() {
        Time.timeScale = 0;
    }

    public void ButtonContinueOnClick() {
        gameObject.SetActive(false);
        Time.timeScale = 1;
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
