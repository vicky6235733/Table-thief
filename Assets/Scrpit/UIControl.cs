using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //public GameObject pausemenupanel;
    public GameObject Panel;
    Animator animator;

    void Start()
    {
    animator= Panel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //OpenPanel();
            if (GameIsPaused)
            {
                
                Resume();
            }
            else
            {
                
                Pause();
        
            }
        }
    }
    public void Resume()
    {
        //  pausemenupanel.SetActive(false);
        OpenPanel();
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }
    public void Pause()
    {
       // pausemenupanel.SetActive(true);
       OpenPanel();
        Time.timeScale = 0.0f;
        GameIsPaused = true;
    }

    public void Mainmenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenPanel()
    {
        if (Panel != null)
        {
            
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }
}
