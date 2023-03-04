using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class coverControl : MonoBehaviour
{
     public CanvasGroup coverGroup;
     private SpriteRenderer Ob01;
   

    // Start is called before the first frame update
    void Start()
    {
        //coverGroup = this.transform.Find("coverParent").GetComponent<CanvasGroup>();
        Ob01=this.transform.Find("cover1").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        { 
            coverGroup.DOFade(0.2f, 0.5f);
            Ob01.DOFade(0.2f, 0.5f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        { 
            coverGroup.DOFade(1.0f, 0.5f); 
            Ob01.DOFade(1.0f, 0.5f);
    }
    }
}
