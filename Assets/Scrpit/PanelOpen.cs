using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpen : MonoBehaviour
{
    public GameObject Panel;
  
    public void Update()
    {
	    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenPanel();
		 }
        
    
    }
    public void OpenPanel()
    {
        if(Panel != null)
        {
		//panel.SetActive(true);
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }

   
   
}
