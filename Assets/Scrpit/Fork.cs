using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using UnityEngine.Random;


public class Fork : MonoBehaviour
{
    public Transform player;
    public float Speed = 5;
    public GameObject TitleObject;
    private float triggerminX;
    private float triggermaxX;
    private float DropX;
    private float DropY;
  
    private float Rotation;
    public GameObject forktable;
    public GameObject DropHint;
    public Text DropHinttext;
    private bool IsDroped=false;
    
    
   //public GameObject fork;
    // Start is called before the first frame update
    
    void Start()
    {
         
        //
        DropHint.SetActive(false);
        forktable.SetActive(true);
  
        triggerminX = TitleObject.transform.position.x+5.0f;
        triggermaxX = TitleObject.transform.position.x-5.0f;
        DropX = (float)Random.Range(triggerminX+10.0f,triggermaxX+15.0f);
        DropY = (float)Random.Range(-2.0f,-3.0f);
        Rotation = (float)Random.Range(0.0f,0.001f);
        Debug.Log(DropY);

    }
  

    // Update is called once per frame
    void Update()
    {   
        
        if( player.position.x < triggerminX)//只設定超過距離就觸發
        {
            if(!IsDroped){
            
            DropHint.SetActive(true);
            DropHinttext.text = "注意前方掉落物!";
            transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(DropX, DropY,30), Speed*Time.deltaTime);
            //transform.localEulerAngles = Vector3.MoveTowards(gameObject.transform.localEulerAngles, new Vector3(0, 0, Rotation), 0.01f * Time.deltaTime);
            }else{//用isdroped控制停止觸發，並關閉Active
                forktable.SetActive(false);
                DropHint.SetActive(false);
            }
        }    

    Debug.Log(IsDroped);

    }
    void LateUpdate(){
            if(transform.position.y < 0)   Invoke("setAct",0.05f);
          
    }
    private void setAct(){
        IsDroped = true;//已經掉落，下次不再觸發
        CancelInvoke("setAct");//關閉延遲時間
    }

  





}
