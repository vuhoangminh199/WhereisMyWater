﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour {
    
    
    private Camera cam;
    private float Tile;
    public GameObject currentImage; 
    float particleLifeTime=100000000.0f;
    public bool flag = false;
    private AudioSource audioSource;
    public AudioClip dirtClip;
    void Start()
    {
        cam = GameObject.Find("GameCamera").GetComponent<Camera>();
        Tile = cam.orthographicSize / Camera.main.orthographicSize;
        audioSource = GetComponent<AudioSource>();
    }

    void TouchDes()
    {   
            if (Input.GetMouseButton(0))
                {
                    Vector3 tem =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector3 touc = tem - Camera.main.transform.position;
                    touc = touc* Tile;
                    //if (colli.OverlapPoint(new Vector2(touc.x, touc.y)))
                    // .5f la ban kinh cua collider
                    if (Mathf.Abs(touc.x - transform.position.x) <= .5f && Mathf.Abs(touc.y - transform.position.y) <= .5f){
                       // Destroy(gameObject);
                       audioSource.PlayOneShot(dirtClip);
                    //    gameObject.SetActive(false);
                        Destroy(gameObject,0.1f);
                    }      
                } 
    }

    void MovementAnimation(){
		Vector3 movementScale=new Vector3(1.0f,1.0f,1.0f);// metaball			
		movementScale.x+=Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x)/30.0f;
		movementScale.z+=Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y)/30.0f;
		movementScale.y=1.0f;		
		currentImage.transform.localScale=movementScale;
	}

	
	void ScaleDown(){ 
		float scaleValue = 1.0f-Time.time/particleLifeTime;
        Debug.Log("SPF: "+ 1/Time.deltaTime);
        Vector2 particleScale=Vector2.one;
		if (scaleValue <= 0) {
			Destroy (gameObject);
		} else{
			particleScale.x=scaleValue;
			particleScale.y=scaleValue;
			transform.localScale=particleScale;
		}
	}

    void Update () {
        TouchDes(); 
        //MovementAnimation(); 
		//ScaleDown();
    }
}
