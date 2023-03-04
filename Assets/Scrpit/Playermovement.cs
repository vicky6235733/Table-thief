using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public int seconds;
    private float initial = 0.0f;
    public float moveSpeed;

    Rigidbody2D rd;
    Vector2 Scale;
    public int layerSet = 2;
    
    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;
   
    void Start()
    {
        Scale = transform.localScale;
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rd = GetComponent<Rigidbody2D>();

    }

// Update is called once per frame
void Update()
    {
      
            float horizontally = Input.GetAxis("Horizontal");
            float vertically = Input.GetAxis("Vertical");
            rd.velocity = new Vector2(horizontally, vertically) * initial;
            AnimationRunner();

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                mySpriteRenderer.flipX = false;
                //myAnimator.SetInteger("Status", 1);
            
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                mySpriteRenderer.flipX = true;//turn around
                //myAnimator.SetInteger("Status", 1);
             
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(layerSet == 2){
                transform.localScale = new Vector2(0.6f,0.6f);
                transform.position = new Vector2(transform.position.x,-2f);
                //Scale = transform.localScale;
                layerSet=1;
                
                }else if(layerSet == 3){
                transform.localScale = new Vector2(0.8f,0.8f);
                transform.position = new Vector2(transform.position.x,-3.55f);
   
                //myAnimator.SetInteger("Status", 1);
                layerSet=2;
                }
                
                
               
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if(layerSet == 1){
                transform.localScale = new Vector2(0.8f,0.8f);
                transform.position = new Vector2(transform.position.x,-3.55f);

                //myAnimator.SetInteger("Status", 1);
                layerSet=2;
                }else if(layerSet == 2){
                transform.localScale = new Vector2(1.0f,1.0f);
                transform.position = new Vector2(transform.position.x,-5f);
                //myAnimator.SetInteger("Status", 1);
                layerSet=3;
                }
                
            }
            
            
        
       Debug.Log(layerSet);
    }
    public void Walk()
    {
        initial = moveSpeed;
    }
    public void AnimationRunner(){
        if(Input.GetKey(KeyCode.LeftArrow)) myAnimator.SetInteger("Status", 1);
        else if(Input.GetKey(KeyCode.RightArrow)) myAnimator.SetInteger("Status", 1);
        else if(Input.GetKey(KeyCode.UpArrow)) myAnimator.SetInteger("Status", 1);
        else if(Input.GetKey(KeyCode.DownArrow)) myAnimator.SetInteger("Status", 1);
        else myAnimator.SetInteger("Status", 0);
    }
    
}

