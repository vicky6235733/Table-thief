using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class touchItem : MonoBehaviour
{
    public GameObject green;
    public GameObject pink;
    public GameObject blue;
    public GameObject purple;
    //public GameObject FloatPoint;
    public GameObject FullScore;
    public Text scoretext;
    public float score;
    public float animationtime;
    //
    private float fromscore;
    private float toscore;
    private int getTarget=0;
   
    //
   

    void Start()
    {
       
    }

    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("oatmeal"))
        {
            Destroy(collision.gameObject);
            Test(100f);
        }
        else if (collision.gameObject.CompareTag("knife"))
        {
            Destroy(collision.gameObject);
            getTarget = 1;
        }
        else if (collision.gameObject.CompareTag("bread"))
        {
            Destroy(collision.gameObject);
            Test(300f);
        }
        else if (collision.gameObject.CompareTag("cheese"))
        {
            Destroy(collision.gameObject);
            Test(1000f);
        }
        else if (collision.gameObject.CompareTag("doritos"))
        {
            Destroy(collision.gameObject);
            Test(500f);
        }
         
        else if (collision.gameObject.CompareTag("FullScore") && getTarget == 1) 
        {
            RollingScore();
        }
        else if (collision.gameObject.CompareTag("fork"))//受傷扣時間
        {
            
           Countdowntime.desec=5;
        }
       

    }

    private void RollingScore()
    {
        FullScore.SetActive(true);
        fromscore = 0;
        toscore =  score; 
        LeanTween.value(fromscore, toscore, animationtime)
            .setEase(LeanTweenType.easeInOutQuart)
            .setOnUpdate(UpateScoreUI);
        
            
    }

    private void UpateScoreUI(float _obj)
    {
        fromscore = _obj;
        scoretext.text = "score:" + _obj.ToString("000000");
    }
    public void Test(float Addpoints)
    {
       if (Addpoints==100)
        {
            GameObject gb = Instantiate(green, transform.position, Quaternion.identity);
            gb.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + Addpoints.ToString();
            score += Addpoints;
            scoretext.text = "+" + score.ToString();
        }
        else if (Addpoints == 300)
        {
            GameObject gb = Instantiate(blue, transform.position, Quaternion.identity);
            gb.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + Addpoints.ToString();
            score += Addpoints;
            scoretext.text = "+" + score.ToString();
        }
        else if (Addpoints == 500)
        {
            GameObject gb = Instantiate(pink, transform.position, Quaternion.identity);
            gb.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + Addpoints.ToString();
            score += Addpoints;
            scoretext.text = "+" + score.ToString();
        }
        else if (Addpoints == 1000)
        {
            GameObject gb = Instantiate(purple, transform.position, Quaternion.identity);
            gb.transform.GetChild(0).GetComponent<TextMesh>().text = "+" + Addpoints.ToString();
            score += Addpoints;
            scoretext.text = "+" + score.ToString();
        }

    }
    //**************
   
}
